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
    public partial class TeacherPaymentCancel : Form
    {
        public TeacherPaymentCancel()
        {
            InitializeComponent();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
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
                var filteredExpenses = dbContext.expenses
            .Where(expense => expense.Type == "Öğretmen Ödeme Yapma" && expense.Date.Year == selectedYear && expense.Date.Month == selectedMonth)
            .Select(expense => new
            {
                expense.Id,
                expense.Date,
                expense.Information,
                expense.Amount
            })
            .ToList();

                paymentsDgv.DataSource = filteredExpenses;
            }
            paymentsDgv.Columns["Id"].HeaderText = "Gider No";
            paymentsDgv.Columns["Date"].HeaderText = "Tarih";
            paymentsDgv.Columns["Information"].HeaderText = "Bilgi";
            paymentsDgv.Columns["Amount"].HeaderText = "Tutar";


        }

        private void CancelPaymentBtn_Click(object sender, EventArgs e)
        {
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
                // Get the selected expense ID from the DataGridView
                int selectedExpenseId = (int)paymentsDgv.SelectedRows[0].Cells["Id"].Value;

                // Confirm with the user if they want to delete the expense
                DialogResult result = MessageBox.Show("Ödemeyi silmek istediğinize emin misiniz?",
                    "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MyDbContext dbContext = new MyDbContext())
                    {
                        // Find the expense to delete
                        Expense expenseToDelete = dbContext.expenses.Find(selectedExpenseId);
                        if (expenseToDelete != null)
                        {
                            // Remove the expense from the DbContext and save changes
                            dbContext.expenses.Remove(expenseToDelete);
                            dbContext.SaveChanges();                        

                            MessageBox.Show("Ödeme başarıyla silindi.");

                            // Re-fetch the data and re-bind it to the paymentsDgv DataGridView
                            var filteredExpenses = dbContext.expenses
                            .Where(expense => expense.Type == "Öğretmen Ödeme Yapma" && expense.Date.Year == selectedYear && expense.Date.Month == selectedMonth)
                            .Select(expense => new
                            {
                                expense.Id,
                                expense.Date,
                                expense.Information,
                                expense.Amount
                            })
                            .ToList();

                            paymentsDgv.DataSource = filteredExpenses;
                        }
                        paymentsDgv.Columns["Id"].HeaderText = "Gider No";
                        paymentsDgv.Columns["Date"].HeaderText = "Tarih";
                        paymentsDgv.Columns["Information"].HeaderText = "Bilgi";
                        paymentsDgv.Columns["Amount"].HeaderText = "Tutar";
                    }
                    }
                    
                    
                }
            
            else
            {
                MessageBox.Show("Lütfen silmek için ödeme seçiniz.");
            }
        }
    }
}
