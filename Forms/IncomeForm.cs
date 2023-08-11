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
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void AddIncomeBtn_Click(object sender, EventArgs e)
        {
            // Get the selected type, information, date, and amount
            if (IncomeTypeCmBox.SelectedItem != null)
            {
                string selectedType = IncomeTypeCmBox.SelectedItem.ToString();
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
                    // Create a new Income object
                    Income income = new Income
                    {
                        Type = selectedType,
                        Information = information,
                        Date = selectedDate,
                        Amount = amount
                    };

                    // Add the Income object to the database context
                    dbContext.incomes.Add(income);

                    // Save the changes to the database
                    dbContext.SaveChanges();

                    MessageBox.Show("Gelir başarıyla eklendi.");
                }
                
            }
            else
            {
                MessageBox.Show("Gelir tipini seçiniz.");

            }

        }
    }
}
