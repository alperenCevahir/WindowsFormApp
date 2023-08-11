using KuzeyYildizi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYildizi.Forms
{
    public partial class StudentUpdateDelete : Form
    {
        public StudentUpdateDelete()
        {
            InitializeComponent();
        }

        private void NameSurnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = NameSurnameTxt.Text.ToLower();

        

            using (var db = new MyDbContext())
            {
                // Query the database for properties that match the search term
                var matchingStudents = db.students
                    .Where(s => (s.Name.ToLower() + " " + s.Surname.ToLower()).Contains(searchTerm))        
            .ToList();

                // Display the search results in a DataGridView control
                dataGridView1.DataSource = matchingStudents;
                dataGridView1.Columns["Id"].HeaderText = "Öğrenci No";
                dataGridView1.Columns["TcNo"].HeaderText = "Tc No";
                dataGridView1.Columns["Name"].HeaderText = "Adı";
                dataGridView1.Columns["Surname"].HeaderText = "Soyadı";
                dataGridView1.Columns["TelNo"].HeaderText = "Tel No";
                dataGridView1.Columns["StudentGrade"].HeaderText = "Sınıfı";
                dataGridView1.Columns["StartDate"].HeaderText = "Başlangıç Tarihi";
                dataGridView1.Columns["BloodType"].HeaderText = "Kan Grubu";
                dataGridView1.Columns["Diseases"].HeaderText = "Hastalığı";
                dataGridView1.Columns["Medicines"].HeaderText = "İlaçları";
                dataGridView1.Columns["School"].HeaderText = "Okulu";
                dataGridView1.Columns["IncludeFood"].HeaderText = "Yemek";
                dataGridView1.Columns["Cash"].HeaderText = "Nakit";
                dataGridView1.Columns["CreditCard"].HeaderText = "Kredi Kartı";
                dataGridView1.Columns["Transfer"].HeaderText = "Havale";
                dataGridView1.Columns["BirthPlaceAndYear"].HeaderText = "Doğum Tarihi ve Yeri";
                dataGridView1.Columns["StudentGender"].HeaderText = "Cinsiyet";
                dataGridView1.Columns["IsFatherAlive"].HeaderText = "Baba Hayatta";
                dataGridView1.Columns["IsMotherAlive"].HeaderText = "Anne Hayatta";
                dataGridView1.Columns["MotherTc"].HeaderText = "Anne Tc";
                dataGridView1.Columns["FatherTc"].HeaderText = "Baba Tc";
                dataGridView1.Columns["MotherIsCustodian"].HeaderText = "Anne Veli";
                dataGridView1.Columns["FatherIsCustodian"].HeaderText = "Baba Veli";
                dataGridView1.Columns["ParentsLiveTogether"].HeaderText = "Anne Baba Birlikte Yaşıyor";
                dataGridView1.Columns["MotherNameSurname"].HeaderText = "Anne İsim Soyisim";
                dataGridView1.Columns["FatherNameSurname"].HeaderText = "Baba İsim Soyisim";
                dataGridView1.Columns["MotherTelNo"].HeaderText = "Anne Tel";
                dataGridView1.Columns["FatherTelNo"].HeaderText = "Baba Tel";
                dataGridView1.Columns["MotherOccupation"].HeaderText = "Anne Meslek";
                dataGridView1.Columns["FatherOccupation"].HeaderText = "Baba Meslek";
                dataGridView1.Columns["MotherAddress"].HeaderText = "Anne Adres";
                dataGridView1.Columns["FatherAddress"].HeaderText = "Baba Adres";
                dataGridView1.Columns["Total"].HeaderText = "Toplam Fiyat";
                dataGridView1.Columns["Installment"].HeaderText = "Taksit";
                dataGridView1.Columns["MonthlyAmount"].HeaderText = "Aylık Miktar";
                dataGridView1.Columns["PaymentWeek"].HeaderText = "Ödeme Haftası";
                dataGridView1.Columns["PaidInstallment"].HeaderText = "Ödenmiş Taksit";
                dataGridView1.Columns["Emergency1NameSurname"].HeaderText = "Acil Durum 1 Ad Soyad";
                dataGridView1.Columns["Emergency1TelNo"].HeaderText = "Acil Durum 1 Tel No";
                dataGridView1.Columns["Emergency1Relativity"].HeaderText = "Acil Durum 1 Yakınlık";
                dataGridView1.Columns["Emergency2NameSurname"].HeaderText = "Acil Durum 2 Ad Soyad";
                dataGridView1.Columns["Emergency2TelNo"].HeaderText = "Acil Durum 2 Tel No";
                dataGridView1.Columns["Emergency2Relativity"].HeaderText = "Acil Durum 2 Yakınlık";
                dataGridView1.Columns["Emergency3NameSurname"].HeaderText = "Acil Durum 3 Ad Soyad";
                dataGridView1.Columns["Emergency3TelNo"].HeaderText = "Acil Durum 3 Tel No";
                dataGridView1.Columns["Emergency3Relativity"].HeaderText = "Acil Durum 3 Yakınlık";

          }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Öğrenci bilgilerini güncellemek istediğinize emin misiniz?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (var db = new MyDbContext())
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int studentId = Convert.ToInt32(row.Cells["Id"].Value);

                        var student = db.students.FirstOrDefault(s => s.Id == studentId);
                        if (student != null)
                        {
                            student.TcNo = row.Cells["TcNo"].Value.ToString();
                            student.Name = row.Cells["Name"].Value.ToString();
                            student.Surname = row.Cells["Surname"].Value.ToString();
                            student.TelNo = row.Cells["TelNo"].Value.ToString();
                            student.StudentGrade = Convert.ToInt16(row.Cells["StudentGrade"].Value);
                            student.StartDate = DateTime.Parse(row.Cells["StartDate"].Value.ToString());
                            student.BloodType = row.Cells["BloodType"].Value.ToString();
                            student.Diseases = row.Cells["Diseases"].Value.ToString();
                            student.Medicines = row.Cells["Medicines"].Value.ToString();
                            student.School = row.Cells["School"].Value.ToString();
                            student.IncludeFood = Convert.ToBoolean(row.Cells["IncludeFood"].Value);
                            student.Cash = Convert.ToBoolean(row.Cells["Cash"].Value);
                            student.CreditCard = Convert.ToBoolean(row.Cells["CreditCard"].Value);
                            student.Transfer = Convert.ToBoolean(row.Cells["Transfer"].Value);
                            student.BirthPlaceAndYear = row.Cells["BirthPlaceAndYear"].Value.ToString();
                            student.StudentGender = row.Cells["StudentGender"].Value.ToString();
                            student.IsFatherAlive = Convert.ToBoolean(row.Cells["IsFatherAlive"].Value);
                            student.IsMotherAlive = Convert.ToBoolean(row.Cells["IsMotherAlive"].Value);
                            student.MotherTc = row.Cells["MotherTc"].Value.ToString();
                            student.FatherTc = row.Cells["FatherTc"].Value.ToString();
                            student.MotherIsCustodian = row.Cells["MotherIsCustodian"].Value.ToString();
                            student.FatherIsCustodian = row.Cells["FatherIsCustodian"].Value.ToString();
                            student.ParentsLiveTogether = Convert.ToBoolean(row.Cells["ParentsLiveTogether"].Value);
                            student.MotherNameSurname = row.Cells["MotherNameSurname"].Value.ToString();
                            student.FatherNameSurname = row.Cells["FatherNameSurname"].Value.ToString();
                            student.MotherTelNo = row.Cells["MotherTelNo"].Value.ToString();
                            student.FatherTelNo = row.Cells["FatherTelNo"].Value.ToString();
                            student.MotherOccupation = row.Cells["MotherOccupation"].Value.ToString();
                            student.FatherOccupation = row.Cells["FatherOccupation"].Value.ToString();
                            student.MotherAddress = row.Cells["MotherAddress"].Value.ToString();
                            student.FatherAddress = row.Cells["FatherAddress"].Value.ToString();
                            student.Total = Convert.ToInt32(row.Cells["Total"].Value);
                            student.Installment = Convert.ToInt32(row.Cells["Installment"].Value);
                            student.PaymentWeek = row.Cells["PaymentWeek"].Value.ToString();
                            student.PaidInstallment = Convert.ToInt32(row.Cells["PaidInstallment"].Value);
                            student.Emergency1NameSurname = row.Cells["Emergency1NameSurname"].Value.ToString();
                            student.Emergency1TelNo = row.Cells["Emergency1TelNo"].Value.ToString();
                            student.Emergency1Relativity = row.Cells["Emergency1Relativity"].Value.ToString();
                            student.Emergency2NameSurname = row.Cells["Emergency2NameSurname"].Value.ToString();
                            student.Emergency2TelNo = row.Cells["Emergency2TelNo"].Value.ToString();
                            student.Emergency2Relativity = row.Cells["Emergency2Relativity"].Value.ToString();
                            student.Emergency3NameSurname = row.Cells["Emergency3NameSurname"].Value.ToString();
                            student.Emergency3TelNo = row.Cells["Emergency3TelNo"].Value.ToString();
                            student.Emergency3Relativity = row.Cells["Emergency3Relativity"].Value.ToString();
                        }
                    }

                    db.SaveChanges();
                }
                MessageBox.Show("Öğrenci bilgileri başarıyla güncelleştirildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var db = new MyDbContext())
                {
                    foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                    {
                        int rowIndex = cell.RowIndex;
                        int studentId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

                        var student = db.students.FirstOrDefault(s => s.Id == studentId);

                        if (student != null)
                        {
                            db.students.Remove(student);
                        }
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Selected student(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView to reflect the updated data
                filterBtn_Click(sender, e);
            }
        }
    }
}
