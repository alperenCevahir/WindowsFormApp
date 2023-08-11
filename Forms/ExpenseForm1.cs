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
    public partial class ExpenseForm1 : Form
    {
        public ExpenseForm1()
        {
            InitializeComponent();
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            if (ExpenseTypeCmBox.SelectedItem != null)
            {
                // Get the selected type, information, date, and amount
                string selectedType = ExpenseTypeCmBox.SelectedItem.ToString();
                string information = NoteTxt.Text;
                DateTime selectedDate = DateTime.Now;
                double amount;

                if (!double.TryParse(AmountTxt.Text, out amount))
                {
                    MessageBox.Show("Geçersiz miktar, lütfen geçerli bir miktar giriniz.");
                    return;
                }

                using (MyDbContext dbContext = new MyDbContext())
                {
                    // Create a new Expense object
                    Expense expense = new Expense
                    {
                        Type = selectedType,
                        Information = information,
                        Date = selectedDate,
                        Amount = amount
                    };

                    // Add the Expense object to the database context
                    dbContext.expenses.Add(expense);

                    // Save the changes to the database
                    dbContext.SaveChanges();

                    MessageBox.Show("Gider başarıyla eklendi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gider tipini seçiniz.");

            }
        }
    }
}
