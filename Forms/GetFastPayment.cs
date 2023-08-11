using KuzeyYildizi.Classes;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using Application = Microsoft.Office.Interop.Word.Application;
using Range = Microsoft.Office.Interop.Word.Range;

namespace KuzeyYildizi.Forms
{
    public partial class GetFastPayment : Form
    {

        public GetFastPayment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = NameSurnameTxt.Text.ToLower();
            int selectedGrade;

            // Check if a valid grade has been selected
            if (!int.TryParse(ClassCmBox.Text, out selectedGrade))
            {
                MessageBox.Show("Lütfen sınıf seçiniz.");
                return;
            }

            using (var db = new MyDbContext())
            {
                // Query the database for properties that match the search term
                var matchingStudents = db.students
                    .Where(s => (s.Name.ToLower() + " " + s.Surname.ToLower()).Contains(searchTerm)
                         && s.StudentGrade == selectedGrade)
            .ToList();

                // Display the search results in a DataGridView control
                dgvResults.DataSource = matchingStudents;
                dgvResults.Columns["Id"].HeaderText = "Öğrenci No";
                dgvResults.Columns["TcNo"].HeaderText = "Tc No";
                dgvResults.Columns["Name"].HeaderText = "Adı";
                dgvResults.Columns["Surname"].HeaderText = "Soyadı";
                dgvResults.Columns["TelNo"].HeaderText = "Tel No";
                dgvResults.Columns["StudentGrade"].HeaderText = "Sınıfı";
                dgvResults.Columns["StartDate"].HeaderText = "Başlangıç Tarihi";
                dgvResults.Columns["School"].HeaderText = "Okulu";
                dgvResults.Columns["IncludeFood"].HeaderText = "Yemek";
                dgvResults.Columns["Cash"].HeaderText = "Nakit";
                dgvResults.Columns["CreditCard"].HeaderText = "Kredi Kartı";
                dgvResults.Columns["Transfer"].HeaderText = "Havale";
                dgvResults.Columns["BirthPlaceAndYear"].HeaderText = "Doğum Tarihi ve Yeri";
                dgvResults.Columns["StudentGender"].HeaderText = "Cinsiyet";
                dgvResults.Columns["MotherNameSurname"].HeaderText = "Anne İsim Soyisim";
                dgvResults.Columns["FatherNameSurname"].HeaderText = "Baba İsim Soyisim";
                dgvResults.Columns["MotherTelNo"].HeaderText = "Anne Tel";
                dgvResults.Columns["FatherTelNo"].HeaderText = "Baba Tel";
                dgvResults.Columns["Total"].HeaderText = "Toplam Fiyat";
                dgvResults.Columns["Installment"].HeaderText = "Taksit";
                dgvResults.Columns["MonthlyAmount"].HeaderText = "Aylık Miktar";
                dgvResults.Columns["PaymentWeek"].HeaderText = "Ödeme Haftası";
                dgvResults.Columns["PaidInstallment"].HeaderText = "Ödenmiş Taksit";

            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}
        private void PaymentAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TakePaymentBtn_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                // Get the selected student from the DataGridView
                DataGridViewRow selectedRow = dgvResults.SelectedRows[0];
                Student selectedStudent = selectedRow.DataBoundItem as Student;
                double PaymentAmount = (double)selectedStudent.MonthlyAmount;
                if(!string.IsNullOrWhiteSpace(PaymentAmountTxt.Text))
                {
                    PaymentAmount = double.Parse(PaymentAmountTxt.Text);
                }

                // Perform operations with the selected student
                if (selectedStudent != null)
                {
                    DateTime currentDateTime = DateTime.Now;
                    using (MyDbContext dbContext = new MyDbContext())
                    {
                        var selectedStudent1 = dbContext.students.Find(selectedStudent.Id);
                        selectedStudent1.PaidInstallment++; // Increment the PaidInstallment property by one
                        Payments payment = new Payments
                        {
                            Date = PaymentDateDTP.Value,
                            StudentId = selectedStudent1.Id,
                            Amount = PaymentAmount,
                            Student = selectedStudent1 // Set the Student navigation property
                        };
                        // Add the payment object to the DbContext and save changes
                        dbContext.payments.Add(payment);
                        dbContext.SaveChanges();
                    }                    
                    // Load the Word document template
                    Application wordApp = new Application();
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string documentPath = Path.Combine(baseDirectory, "Makbuz.docx");
                    Document doc = wordApp.Documents.Open(documentPath);

                    // Find and replace specific placeholders in the document with form values
                    FindAndReplace(doc, "ogrenciadsoyad", selectedStudent.Name + " " + selectedStudent.Surname);
                    FindAndReplace(doc, "odemeyapan", WhoIsPayingTxt.Text);
                    FindAndReplace(doc, "odemetarihi", currentDateTime.ToString("dd.MM.yyyy"));
                    FindAndReplace(doc, "odemetutari", PaymentAmount.ToString());

                    int correctPaidInstallment = selectedStudent.PaidInstallment + 1;
                    // Save the modified document to the desktop
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    string folderName = "Makbuzlar";
                    string savePath = Path.Combine(desktopPath, folderName, selectedStudent.TcNo + selectedStudent.Name + selectedStudent.Surname + correctPaidInstallment +".doc");
                    doc.SaveAs2(savePath);

                    // Close the Word document
                    doc.Close();

                    // Quit the Word application
                    wordApp.Quit();
                    // Display print preview dialog for the Word document
                    Process.Start(new ProcessStartInfo(savePath) { UseShellExecute = true });

                    MessageBox.Show("Makbuz başarıyla oluşturuldu");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci seçilmedi");
                
            }

        }
        private void FindAndReplace(Document doc, string placeholder, string value)
        {
            foreach (Range range in doc.StoryRanges)
            {
                Find find = range.Find;
                find.Text = placeholder;
                find.Replacement.Text = value;
                find.Execute(Replace: WdReplace.wdReplaceAll);
            }
        }

        private void PaymentAmountTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
