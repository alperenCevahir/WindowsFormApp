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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            ExpenseForm frm = new ExpenseForm();
            frm.Show();
        }

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {
            ExpenseForm1 frm = new ExpenseForm1();
            frm.Show();
        }

        private void StudentPaymentCancel_Click(object sender, EventArgs e)
        {
            StudentPaymentCancel frm = new StudentPaymentCancel();
            frm.Show();
        }

        private void TeacherPaymentCancel_Click(object sender, EventArgs e)
        {
            TeacherPaymentCancel frm = new TeacherPaymentCancel();
            frm.Show();
        }

        private void WeeklyCollectionTable_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyCollectionTable_Click(object sender, EventArgs e)
        {

        }

        private void TeacherPayments_Click(object sender, EventArgs e)
        {

        }

        private void StudentCollectionReceipt_Click(object sender, EventArgs e)
        {

        }

        private void StudentCollectionReceiptReprint_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
