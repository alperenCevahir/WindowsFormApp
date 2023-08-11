using KuzeyYildizi.Classes;
using System.Data;

namespace KuzeyYildizi.Forms
{
    public partial class StudentPaymentCancel : Form
    {
        public StudentPaymentCancel()
        {
            InitializeComponent();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string studentName = nameTextBox.Text;
            string studentSurname = surnameTextBox.Text;
            int selectedYear;
            int selectedMonth;

            if (!int.TryParse(YearTxt.Text, out selectedYear) || selectedYear <= 0)
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }

            selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)

            using (MyDbContext dbContext = new MyDbContext())
            {
                var filteredPayments = dbContext.payments
                    .Where(payment =>
                        payment.Student.Name.Contains(studentName) &&
                        payment.Student.Surname.Contains(studentSurname) &&
                        payment.Date.Year == selectedYear &&
                        payment.Date.Month == selectedMonth)
                    .Select(payment => new
                    {
                        payment.Id,
                        StudentName = payment.Student.Name,
                        StudentSurname = payment.Student.Surname,
                        payment.Date,
                        payment.Amount,
                        payment.Student.TcNo,
                        payment.Student.TelNo,
                        payment.Student.StudentGrade
                    })
                    .ToList();

                paymentsDgv.DataSource = filteredPayments;
            }
            paymentsDgv.Columns["Id"].HeaderText = "Öğrenci No";
            paymentsDgv.Columns["StudentName"].HeaderText = "Adı";
            paymentsDgv.Columns["StudentSurname"].HeaderText = "Soyadı";
            paymentsDgv.Columns["Date"].HeaderText = "Tarih";
            paymentsDgv.Columns["Amount"].HeaderText = "Tutar";
            paymentsDgv.Columns["TcNo"].HeaderText = "Tc No";
            paymentsDgv.Columns["TelNo"].HeaderText = "Tel No";
            paymentsDgv.Columns["StudentGrade"].HeaderText = "Sınıfı";
        }


        private void paymentsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CancelPaymentBtn_Click(object sender, EventArgs e)
        {
            string studentName = nameTextBox.Text;
            string studentSurname = surnameTextBox.Text;
            int selectedYear;
            int selectedMonth;

            if (!int.TryParse(YearTxt.Text, out selectedYear) || selectedYear <= 0)
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }

            selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)
            if (paymentsDgv.SelectedRows.Count > 0)
            {
                // Show a warning message to confirm deletion
                DialogResult result = MessageBox.Show("Ödemeyi silmek istediğinize emin misiniz?", "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Get the selected payment ID from the DataGridView
                    DataGridViewRow selectedRow = paymentsDgv.SelectedRows[0];
                    int selectedPaymentId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Assuming "Id" is the column name for the payment ID

                    // Perform deletion of the selected payment
                    using (MyDbContext dbContext = new MyDbContext())
                    {
                        var payment = dbContext.payments.Find(selectedPaymentId);
                        if (payment != null)
                        {
                            var student = dbContext.students.Find(payment.StudentId);
                            if (student != null)
                            {
                                student.PaidInstallment--;
                                dbContext.payments.Remove(payment);
                                dbContext.SaveChanges();
                            }

                            // Re-fetch the data and re-bind it to the paymentsDgv DataGridView
                            var filteredPayments = dbContext.payments
                            .Where(payment =>
                                payment.Student.Name.Contains(studentName) &&
                                payment.Student.Surname.Contains(studentSurname) &&
                                payment.Date.Year == selectedYear &&
                                payment.Date.Month == selectedMonth)
                            .Select(payment => new
                            {
                                payment.Id,
                                StudentName = payment.Student.Name,
                                StudentSurname = payment.Student.Surname,
                                payment.Date,
                                payment.Amount,
                                payment.Student.TcNo,
                                payment.Student.TelNo,
                                payment.Student.StudentGrade
                            })
                            .ToList();

                            paymentsDgv.DataSource = filteredPayments;
                        }
                    }

                    paymentsDgv.Columns["Id"].HeaderText = "Ödeme No";
                    paymentsDgv.Columns["StudentName"].HeaderText = "Adı";
                    paymentsDgv.Columns["StudentSurname"].HeaderText = "Soyadı";
                    paymentsDgv.Columns["Date"].HeaderText = "Tarih";
                    paymentsDgv.Columns["Amount"].HeaderText = "Tutar";
                    paymentsDgv.Columns["TcNo"].HeaderText = "Tc No";
                    paymentsDgv.Columns["TelNo"].HeaderText = "Tel No";
                    paymentsDgv.Columns["StudentGrade"].HeaderText = "Sınıfı";
                }
            }
        }
    }
}
