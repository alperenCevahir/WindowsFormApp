using KuzeyYildizi.Classes;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using Application = Microsoft.Office.Interop.Word.Application;
using Range = Microsoft.Office.Interop.Word.Range;

namespace KuzeyYildizi.Forms
{
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();
        }

        private void tcNoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tcNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StartingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = StartingDateTimePicker.Value;
        }

        private void GradeTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void GradeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MotherTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MotherTelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FatherTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FatherTelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency1TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency2TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency3TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TotalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InstallmentTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void InstallmentTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            try { 
            // Check if any of the text boxes are empty
            if (string.IsNullOrEmpty(tcNoTxt.Text) ||
                string.IsNullOrEmpty(nameTxt.Text) ||
                string.IsNullOrEmpty(surnameTxt.Text) ||
                string.IsNullOrEmpty(GradeTxt.Text) ||
                string.IsNullOrEmpty(BirthPlaceAndYearTxt.Text) ||
                string.IsNullOrEmpty(genderComboBox.Text) ||
                string.IsNullOrEmpty(SchoolTxt.Text) ||

                string.IsNullOrEmpty(MotherNameTxt.Text) ||
                string.IsNullOrEmpty(FatherNameTxt.Text) ||
                string.IsNullOrEmpty(OccupationTxt.Text) ||
                string.IsNullOrEmpty(FatherOccupationTxt.Text) ||
                string.IsNullOrEmpty(motherworkingplacetxt.Text) ||
                string.IsNullOrEmpty(fatherworkingplacetxt.Text) ||
                string.IsNullOrEmpty(MotherSurnameTxt.Text) ||
                string.IsNullOrEmpty(FatherSurnameTxt.Text) ||
                string.IsNullOrEmpty(MotherTelNoTxt.Text) ||
                string.IsNullOrEmpty(FatherTelNoTxt.Text) ||
                string.IsNullOrEmpty(MotherAdresTxt.Text) ||
                string.IsNullOrEmpty(FatherAdressTxt.Text) ||

                string.IsNullOrEmpty(TotalTxt.Text) ||
                string.IsNullOrEmpty(InstallmentTxt.Text) ||
                string.IsNullOrEmpty(installmentPaymentWeekCmbox.Text) 

                )
            {
                // Display an error message to the user
                MessageBox.Show("Lütfen yıldızlı boş kutu bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String MotherCustodian;
                String FatherCustodian;
                if (MotherIsCustodianCheckBox.Checked)
                {
                    MotherCustodian = "Evet";
                }
                else
                {
                    MotherCustodian = "Hayır";
                }

                if (FatherIsCustodianCheckBox.Checked)
                {
                    FatherCustodian = "Evet";
                }
                else
                {
                    FatherCustodian = "Hayır";
                }
                string motherName = MotherNameTxt.Text;
                string motherSurname = MotherSurnameTxt.Text;
                string motherNameSurname = motherName + " " + motherSurname;

                string fatherName = FatherNameTxt.Text;
                string fatherSurname = FatherSurnameTxt.Text;
                string fatherNameSurname = fatherName + " " + fatherSurname;
                var student = new Student()
                {
                    TcNo = tcNoTxt.Text,
                    Name = nameTxt.Text,
                    Surname = surnameTxt.Text,
                    TelNo = TelNoTxt.Text,
                    StudentGrade = (int)Int64.Parse(GradeTxt.Text),
                    BirthPlaceAndYear = BirthPlaceAndYearTxt.Text,
                    StudentGender = genderComboBox.Text,
                    StartDate = StartingDateTimePicker.Value,
                    BloodType = BloodTypeTxt.Text,
                    Diseases = DiseaseTxt.Text,
                    Medicines = MedicineTxt.Text,
                    School = SchoolTxt.Text,
                    IncludeFood = FoodCheckBx.Checked,

                    IsFatherAlive = !FatherDeadCheckBox.Checked,
                    IsMotherAlive = !MotherDeadCheckBox.Checked,
                    MotherTc = MotherTcTxt.Text,
                    FatherTc = FatherTcTxt.Text,
                    MotherIsCustodian = MotherCustodian,
                    FatherIsCustodian = FatherCustodian,
                    ParentsLiveTogether = LivesTogetherCheckBox.Checked,
                    MotherNameSurname = motherNameSurname,
                    FatherNameSurname = fatherNameSurname,
                    MotherTelNo = MotherTelNoTxt.Text,
                    FatherTelNo = FatherTelNoTxt.Text,
                    MotherOccupation = OccupationTxt.Text,
                    FatherOccupation = FatherOccupationTxt.Text,
                    MotherAddress = MotherAdresTxt.Text,
                    FatherAddress = FatherAdressTxt.Text,

                    Total = (int)Int32.Parse(TotalTxt.Text),
                    Installment = (int)Int32.Parse(InstallmentTxt.Text),
                    PaymentWeek = installmentPaymentWeekCmbox.Text,
                    Cash = CashCheckBox.Checked,
                    CreditCard = CreditCardCheckBox.Checked,
                    Transfer = TransferCheckBox.Checked,


                    Emergency1NameSurname = Emergency1NameTxtBox.Text + " " + Emergency1SurnameTxtBox.Text,
                    Emergency2NameSurname = Emergency2NameTxtBox.Text + " " + Emergency2SurnameTxtBox.Text,
                    Emergency3NameSurname = Emergency3NameTxtBox.Text + " " + Emergency3SurnameTxtBox.Text,
                    Emergency1TelNo = Emergency1TelNoTxtBox.Text,
                    Emergency2TelNo = Emergency2TelNoTxtBox.Text,
                    Emergency3TelNo = Emergency3TelNoTxtBox.Text,
                    Emergency1Relativity = Emergency1RelativityTxtBox.Text,
                    Emergency2Relativity = Emergency2RelativityTxtBox.Text,
                    Emergency3Relativity = Emergency3RelativityTxtBox.Text,
                };

              
                using (MyDbContext dbContext = new MyDbContext())
                {
                    dbContext.students.Add(student);
                    dbContext.SaveChanges();
                }

                // Close the form or clear the input fields

                MessageBox.Show("Yeni öğrenci başarıyla eklendi. Çıktı alabilirsiniz");
            }
        }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
}

        private void printButton_Click(object sender, EventArgs e)
        {
            // Load the Word document template
            Application wordApp = new Application();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string documentPath = Path.Combine(baseDirectory, "KayitFormu.doc");
            try
            {
                Document doc = wordApp.Documents.Open(documentPath);
            
            // Find and replace specific placeholders in the document with form values
            FindAndReplace(doc, "ogrenciadsoyad", nameTxt.Text + " " + surnameTxt.Text);
            FindAndReplace(doc, "ogrencitcno", tcNoTxt.Text);
            FindAndReplace(doc, "dogumyeriyili", BirthPlaceAndYearTxt.Text);
            FindAndReplace(doc, "ogrenciokulu", SchoolTxt.Text);
            FindAndReplace(doc, "ogrencisinifi", GradeTxt.Text);
            if (FoodCheckBx.Checked)
            {
                FindAndReplace(doc, "yemekvarmi", "Evet");
            }
            else
            {
                FindAndReplace(doc, "yemekvarmi", "Hayır");
            }
            FindAndReplace(doc, "notvarmi", notetxt.Text);
            FindAndReplace(doc, "anneadsoyad", MotherNameTxt.Text + " " + MotherSurnameTxt.Text);
            FindAndReplace(doc, "babaadsoyad", FatherNameTxt.Text + " " + FatherSurnameTxt.Text);
            FindAndReplace(doc, "annetc", MotherTcTxt.Text);
            FindAndReplace(doc, "babatc", FatherTcTxt.Text);
            FindAndReplace(doc, "annemeslek", OccupationTxt.Text);
            FindAndReplace(doc, "babameslek", FatherOccupationTxt.Text);
            FindAndReplace(doc, "annecalistigiyer", motherworkingplacetxt.Text);
            FindAndReplace(doc, "babacalistigiyer", fatherworkingplacetxt.Text);
            FindAndReplace(doc, "annetelno", MotherTelNoTxt.Text);
            FindAndReplace(doc, "babatelno", FatherTelNoTxt.Text);

            if(genderComboBox.SelectedItem == "Erkek")
            {
                FindAndReplace(doc, "ogrencicinsiyet", "OĞLUM");

            }
            else if(genderComboBox.SelectedItem == "Kız")
            {
                FindAndReplace(doc, "ogrencicinsiyet", "KIZIM");
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordApp.Quit();
                return;
            }
            if (FatherIsCustodianCheckBox.Checked)
            {
                FindAndReplace(doc, "veliadsoyadyeri", FatherNameTxt.Text + " " + FatherSurnameTxt.Text);
                FindAndReplace(doc, "velitcyeri", FatherTcTxt.Text);
                FindAndReplace(doc, "veliadresyeri", FatherAdressTxt.Text);
            }
            else
            {
                FindAndReplace(doc, "veliadsoyadyeri", MotherNameTxt.Text + " " + MotherSurnameTxt.Text);
                FindAndReplace(doc, "velitcyeri", MotherTcTxt.Text);
                FindAndReplace(doc, "veliadresyeri", MotherAdresTxt.Text);    
            }

            //Could be better
            int TotalValue = int.Parse(TotalTxt.Text);
            int InstallmentValue = int.Parse(InstallmentTxt.Text);
            int MonthlyInstallment = TotalValue / InstallmentValue;
            FindAndReplace(doc, "ayliktaksittutari", MonthlyInstallment.ToString());
            FindAndReplace(doc, "yilliktutar", TotalTxt.Text);
            FindAndReplace(doc, "Taksitsayisi", InstallmentValue.ToString());

                if (CashCheckBox.Checked)
            {
                FindAndReplace(doc, "nakitodemevarmi", "Evet");
            }
            else
            {
                FindAndReplace(doc, "nakitodemevarmi", "Hayır");
            }
            if (CreditCardCheckBox.Checked)
            {
                FindAndReplace(doc, "karrtodemevarmi", "Evet");
            }
            else
            {
                FindAndReplace(doc, "karrtodemevarmi", "Hayır");
            }
            if (TransferCheckBox.Checked)
            {
                FindAndReplace(doc, "havaleodemevarmi", "Evet");
            }
            else
            {
                FindAndReplace(doc, "havaleodemevarmi", "Hayır");
            }

            FindAndReplace(doc, "acildurumtel1", Emergency1TelNoTxtBox.Text);
            FindAndReplace(doc, "acildurumtel2", Emergency2TelNoTxtBox.Text);
            FindAndReplace(doc, "acildurumtel3", Emergency3TelNoTxtBox.Text);

            // Save the modified document to the desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string folderName = "Kayıt Formları";
            string savePath = Path.Combine(desktopPath, folderName, tcNoTxt.Text + nameTxt.Text + surnameTxt.Text + ".doc");
            doc.SaveAs2(savePath);

            // Close the Word document
            doc.Close();

            // Quit the Word application
            wordApp.Quit();
            // Display print preview dialog for the Word document
            Process.Start(new ProcessStartInfo(savePath) { UseShellExecute = true });
            MessageBox.Show("Öğrenci dökümanı başarıyla oluşturulup bilgisayara kaydedildi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                wordApp.Quit();
                return;
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

        private void FoodCheckBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TotalTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void KresPrint_Click(object sender, EventArgs e)
        {
            // Load the Word document template
            Application wordApp = new Application();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string documentPath = Path.Combine(baseDirectory, "KayitFormuKres.doc");
            try
            {
                Document doc = wordApp.Documents.Open(documentPath);

                // Find and replace specific placeholders in the document with form values
                FindAndReplace(doc, "ogrenciadsoyad", nameTxt.Text + " " + surnameTxt.Text);
                FindAndReplace(doc, "ogrencitcno", tcNoTxt.Text);
                FindAndReplace(doc, "dogumyeriyili", BirthPlaceAndYearTxt.Text);
                FindAndReplace(doc, "ogrenciokulu", SchoolTxt.Text);
                FindAndReplace(doc, "ogrencisinifi", GradeTxt.Text);
                if (FoodCheckBx.Checked)
                {
                    FindAndReplace(doc, "yemekvarmi", "Evet");
                }
                else
                {
                    FindAndReplace(doc, "yemekvarmi", "Hayır");
                }
                FindAndReplace(doc, "notvarmi", notetxt.Text);
                FindAndReplace(doc, "anneadsoyad", MotherNameTxt.Text + " " + MotherSurnameTxt.Text);
                FindAndReplace(doc, "babaadsoyad", FatherNameTxt.Text + " " + FatherSurnameTxt.Text);
                FindAndReplace(doc, "annetc", MotherTcTxt.Text);
                FindAndReplace(doc, "babatc", FatherTcTxt.Text);
                FindAndReplace(doc, "annemeslek", OccupationTxt.Text);
                FindAndReplace(doc, "babameslek", FatherOccupationTxt.Text);
                FindAndReplace(doc, "annecalistigiyer", motherworkingplacetxt.Text);
                FindAndReplace(doc, "babacalistigiyer", fatherworkingplacetxt.Text);
                FindAndReplace(doc, "annetelno", MotherTelNoTxt.Text);
                FindAndReplace(doc, "babatelno", FatherTelNoTxt.Text);
                string emergencyNameSurname = Emergency1NameTxtBox.Text + " " + Emergency1SurnameTxtBox.Text;
                FindAndReplace(doc, "yakinisim", emergencyNameSurname);
                FindAndReplace(doc, "yakinderece", Emergency1RelativityTxtBox.Text);
                FindAndReplace(doc, "yakinno", Emergency1TelNoTxtBox.Text);
                FindAndReplace(doc, "ogrencikangrubu", BloodTypeTxt.Text);


                if (genderComboBox.SelectedItem == "Erkek")
                {
                    FindAndReplace(doc, "ogrencicinsiyet", "OĞLUM");

                }
                else if (genderComboBox.SelectedItem == "Kız")
                {
                    FindAndReplace(doc, "ogrencicinsiyet", "KIZIM");
                }
                else
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wordApp.Quit();
                    return;
                }
                if (FatherIsCustodianCheckBox.Checked)
                {
                    FindAndReplace(doc, "veliadsoyadyeri", FatherNameTxt.Text + " " + FatherSurnameTxt.Text);
                    FindAndReplace(doc, "velitcyeri", FatherTcTxt.Text);
                    FindAndReplace(doc, "veliadresyeri", FatherAdressTxt.Text);
                }
                else
                {
                    FindAndReplace(doc, "veliadsoyadyeri", MotherNameTxt.Text + " " + MotherSurnameTxt.Text);
                    FindAndReplace(doc, "velitcyeri", MotherTcTxt.Text);
                    FindAndReplace(doc, "veliadresyeri", MotherAdresTxt.Text);
                }

                //Could be better
                int TotalValue = int.Parse(TotalTxt.Text);
                int InstallmentValue = int.Parse(InstallmentTxt.Text);
                int MonthlyInstallment = TotalValue / InstallmentValue;
                FindAndReplace(doc, "ayliktaksittutari", MonthlyInstallment.ToString());
                FindAndReplace(doc, "yilliktutar", TotalTxt.Text);
                FindAndReplace(doc, "Taksitsayisi", InstallmentValue.ToString());
                FindAndReplace(doc, "odemehaftasi", installmentPaymentWeekCmbox.Text);


                if (CashCheckBox.Checked)
                {
                    FindAndReplace(doc, "nakitodemevarmi", "Evet");
                }
                else
                {
                    FindAndReplace(doc, "nakitodemevarmi", "Hayır");
                }
                if (CreditCardCheckBox.Checked)
                {
                    FindAndReplace(doc, "karrtodemevarmi", "Evet");
                }
                else
                {
                    FindAndReplace(doc, "karrtodemevarmi", "Hayır");
                }
                if (TransferCheckBox.Checked)
                {
                    FindAndReplace(doc, "havaleodemevarmi", "Evet");
                }
                else
                {
                    FindAndReplace(doc, "havaleodemevarmi", "Hayır");
                }

                FindAndReplace(doc, "acildurumtel1", Emergency1TelNoTxtBox.Text);
                FindAndReplace(doc, "acildurumtel2", Emergency2TelNoTxtBox.Text);
                FindAndReplace(doc, "acildurumtel3", Emergency3TelNoTxtBox.Text);

                // Save the modified document to the desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string folderName = "Kayıt Formları";
                string savePath = Path.Combine(desktopPath, folderName, tcNoTxt.Text + nameTxt.Text + surnameTxt.Text + ".doc");
                doc.SaveAs2(savePath);

                // Close the Word document
                doc.Close();

                // Quit the Word application
                wordApp.Quit();
                // Display print preview dialog for the Word document
                Process.Start(new ProcessStartInfo(savePath) { UseShellExecute = true });
                MessageBox.Show("Öğrenci dökümanı başarıyla oluşturulup bilgisayara kaydedildi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                wordApp.Quit();
                return;
            }
        }

        private void TelNoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
