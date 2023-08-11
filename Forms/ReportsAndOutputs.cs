using KuzeyYildizi.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
    public partial class ReportsAndOutputs : Form
    {
        public ReportsAndOutputs()
        {
            InitializeComponent();
        }

        private void TotalStudentNumber_Click(object sender, EventArgs e)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add(" ", " ");
                ReportsDgv.Columns.Add(" ", " ");

                // Set the row default cell style to make the rows wider
                ReportsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // Get the number of students from the database
                int studentCount = dbContext.students.Count();

                // Add the "Total Students" row to ReportsDgv
                ReportsDgv.Rows.Add("Öğrenci Sayısı", studentCount);
            }
        }

        private void ClassStudentNumbers_Click(object sender, EventArgs e)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add("Sınıflar", "Sınıf");
                ReportsDgv.Columns.Add("Öğrenciler", "Öğrenci Sayısı");

                // Set the row default cell style to make the rows wider
                ReportsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // Get the count of students in each grade
                for (int grade = 0; grade <= 8; grade++)
                {
                    int studentCount = dbContext.students.Count(s => s.StudentGrade == grade);
                    ReportsDgv.Rows.Add(grade, studentCount);
                }
            }
        }

        private void MontlhyPaidStudents_Click(object sender, EventArgs e)
        {
            int selectedYear;
            if (!int.TryParse(YearTxt.Text, out selectedYear))
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }

            int selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)

            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Set the row default cell style to make the rows wider
                ReportsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add("StudentIdColumn", "Öğrenci Numarası");
                ReportsDgv.Columns.Add("StudentNameColumn", "Öğrenci Adı Soyadı");
                ReportsDgv.Columns.Add("DebtColmun", "Kalan Borç");
                ReportsDgv.Columns.Add("DateColumn", "Ödeme Tarihi");

                // Get the students who paid in the selected time
                var paidStudents = dbContext.payments
                .Where(p => p.Date.Year == selectedYear && p.Date.Month == selectedMonth)
                .GroupBy(p => new { p.StudentId, p.Student.Name, p.Student.Surname, p.Student.Total })
                .Select(group => new
                {
                    StudentId = group.Key.StudentId,
                    FullName = group.Key.Name + " " + group.Key.Surname,
                    TotalPaid = group.Sum(p => p.Amount), // Sum of payment amounts
                    Total = group.Key.Total
                })
                .ToList();

                // Display the paid students in ReportsDgv
                foreach (var student in paidStudents)
                {
                    double totalPaid = student.TotalPaid;
                    double remainingDebt = student.Total - totalPaid;
                    ReportsDgv.Rows.Add(student.StudentId, student.FullName, remainingDebt);
                }
            }
        }

        private void MontlhyUnpaidStudents_Click(object sender, EventArgs e)
        {
            int selectedYear;
            if (!int.TryParse(YearTxt.Text, out selectedYear))
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }

            int selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)

            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add("StudentIdColumn", "Öğrenci Numarası");
                ReportsDgv.Columns.Add("StudentNameColumn", "Öğrenci Adı Soyadı");
                ReportsDgv.Columns.Add("StudentUnpaidAmount", "Taksit Miktarı");
                ReportsDgv.Columns.Add("StudentPaymentTime", "Ödeme Günleri");
                ReportsDgv.Columns.Add("StudentMotherColumn", "Anne Adı Soyadı");
                ReportsDgv.Columns.Add("StudentMotherTelColumn", "Anne Tel No");
                ReportsDgv.Columns.Add("StudentFatherColumn", "Baba Adı Soyadı");
                ReportsDgv.Columns.Add("StudentFatherTelColumn", "Baba Tel No");

                // Get the students who didn't pay in the selected time
                var unpaidStudents = dbContext.students
                    .Where(student => !dbContext.payments
                        .Any(payment => payment.StudentId == student.Id && payment.Date.Year == selectedYear && payment.Date.Month == selectedMonth))
                    .Select(student => new 
                    {
                        student.Id,
                        FullName = student.Name + " " + student.Surname,
                        FatherName = student.FatherNameSurname,
                        FatherTelNo = student.FatherTelNo,
                        MotherName = student.MotherNameSurname,
                        MotherTelNo = student.MotherTelNo,
                        UnpaidAmount = student.MonthlyAmount,
                        PaymentTime = student.PaymentWeek

                    })
                    .ToList();

                // Display the unpaid students in ReportsDgv
                foreach (var student in unpaidStudents)
                {
                    ReportsDgv.Rows.Add(student.Id, student.FullName,student.UnpaidAmount, student.PaymentTime,
                        student.MotherName,student.MotherTelNo, student.FatherName, student.FatherTelNo);
                }
            }
        }

        private void MonthlyIncome_Click(object sender, EventArgs e)
        {
            int selectedYear;
            if (!int.TryParse(YearTxt.Text, out selectedYear))
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }
            

            int selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)
            string selectedIncomeType = IncomeCmBox.Text;
            
            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add("NameColumn", "İsim");
                ReportsDgv.Columns.Add("SurnameColumn", "Soyisim");
                ReportsDgv.Columns.Add("TypeColumn", "Tip");
                ReportsDgv.Columns.Add("AmountColumn", "Miktar");
                ReportsDgv.Columns.Add("DateColumn", "Tarih");
                ReportsDgv.Columns.Add("NoteColumn", "Not");


                // Get payments for the selected year and month

                if (selectedIncomeType == "Toplam")
                {
                    // Get incomes for the selected year and month
                     var incomes = dbContext.incomes
                        .Where(income => income.Date.Year == selectedYear && income.Date.Month == selectedMonth)
                        .Select(income => new { Name = "", Surname = "", income.Type, income.Amount, income.Date, income.Information })
                        .ToList();

                    var payments = dbContext.payments
                    .Where(payment => payment.Date.Year == selectedYear && payment.Date.Month == selectedMonth)
                    .Select(payment => new { payment.Student.Name, payment.Student.Surname, Type = "Ödeme", payment.Amount, payment.Date,Information = "" })
                    .ToList();

                    // Combine payments and incomes into a single list
                    var allData = payments.Concat(incomes);

                    // Display the data in ReportsDgv
                    foreach (var item in allData)
                    {
                        ReportsDgv.Rows.Add(item.Name, item.Surname, item.Type, item.Amount, item.Date, item.Information);
                    }

                    // Calculate the total income
                    double totalIncome = incomes.Sum(income => income.Amount);

                    // Calculate the total payments
                    double totalPayments = payments.Sum(payment => payment.Amount);

                    // Calculate the monthly income
                    double monthlyIncome = totalIncome + totalPayments;

                    // Display the monthly income
                    ReportsDgv.Rows.Add("", "", "Toplam Gelir", monthlyIncome);


                }
                else if(selectedIncomeType == "Ödeme")
                {
                    var payments = dbContext.payments
                    .Where(payment => payment.Date.Year == selectedYear && payment.Date.Month == selectedMonth)
                    .Select(payment => new { payment.Student.Name, payment.Student.Surname, Type = "Ödeme", payment.Amount, payment.Date,Information = "" })
                    .ToList();
                    // Combine payments and incomes into a single list
                    var allData = payments;

                    // Display the data in ReportsDgv
                    foreach (var item in allData)
                    {
                        ReportsDgv.Rows.Add(item.Name, item.Surname, item.Type, item.Amount, item.Date, item.Information);
                    }

                    // Calculate the total payments
                    double totalPayments = payments.Sum(payment => payment.Amount);

                    // Display the monthly income
                    ReportsDgv.Rows.Add("", "", "Toplam Gelir", totalPayments);
                }
                else
                {
                    // Get incomes for the selected year and month
                    var incomes = dbContext.incomes
                        .Where(income => income.Date.Year == selectedYear && income.Date.Month == selectedMonth && income.Type == selectedIncomeType)
                        .Select(income => new { Name = "", Surname = "", Type = income.Type, income.Amount, income.Date, income.Information })
                        .ToList();

                    // Combine payments and incomes into a single list
                    var allData = incomes;

                    // Display the data in ReportsDgv
                    foreach (var item in allData)
                    {
                        ReportsDgv.Rows.Add(item.Name, item.Surname, item.Type, item.Amount, item.Date, item.Information);
                    }

                    // Calculate the total income
                    double totalIncome = incomes.Sum(income => income.Amount);

                    // Display the monthly income
                    ReportsDgv.Rows.Add("", "", "Toplam Gelir", totalIncome);

                }

                
            }
        }

        private void MonthlyExpense_Click(object sender, EventArgs e)
        {
            int selectedYear;
            if (!int.TryParse(YearTxt.Text, out selectedYear))
            {
                MessageBox.Show("Geçersiz yıl girişi, lütfen geçerli bir yıl girin.");
                return;
            }

            int selectedMonth = MonthsCmBox.SelectedIndex + 1; // Add 1 to match month numbers (0-based index)
            string selectedExpenseType = ExpenseCmBox.Text;

            using (MyDbContext dbContext = new MyDbContext())
            {
                // Clear existing data in ReportsDgv
                ReportsDgv.Rows.Clear();
                ReportsDgv.Columns.Clear(); // Clear existing columns, if any

                // Add columns to ReportsDgv
                ReportsDgv.Columns.Add("TypeColumn", "Tip");
                ReportsDgv.Columns.Add("AmountColumn", "Miktar");
                ReportsDgv.Columns.Add("DateColumn", "Tarih");
                ReportsDgv.Columns.Add("InfoColumn", "Not");

                if (selectedExpenseType=="Toplam")
                {
                    // Get expenses for the selected year and month
                    var expenses = dbContext.expenses
                        .Where(expense => expense.Date.Year == selectedYear && expense.Date.Month == selectedMonth)
                        .Select(expense => new { expense.Information, expense.Amount, expense.Type, expense.Date })
                        .ToList();

                    // Display the expenses in ReportsDgv
                    foreach (var expense in expenses)
                    {
                        ReportsDgv.Rows.Add(expense.Type, expense.Amount, expense.Date, expense.Information);
                    }

                    // Calculate the total expenses
                    double totalExpenses = expenses.Sum(expense => expense.Amount);

                    // Display the total expenses
                    ReportsDgv.Rows.Add("Toplam Gider", totalExpenses);
                }
                else
                {
                    // Get expenses for the selected year and month
                    var expenses = dbContext.expenses
                        .Where(expense => expense.Date.Year == selectedYear && expense.Date.Month == selectedMonth && expense.Type == selectedExpenseType)
                        .Select(expense => new { expense.Information, expense.Amount, expense.Type, expense.Date })
                        .ToList();

                    // Display the expenses in ReportsDgv
                    foreach (var expense in expenses)
                    {
                        ReportsDgv.Rows.Add(expense.Type, expense.Amount, expense.Date, expense.Information);
                    }

                    // Calculate the total expenses
                    double totalExpenses = expenses.Sum(expense => expense.Amount);

                    // Display the total expenses
                    ReportsDgv.Rows.Add("Toplam Gider", totalExpenses);
                }
                
            }
        }
            private void YearTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void YearTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
