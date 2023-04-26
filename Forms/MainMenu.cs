using KuzeyYildizi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYildizi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.KY_LOGO;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            AddStudent studentForm = new AddStudent();
            studentForm.Show();

        }


        private void Accounting_Click_1(object sender, EventArgs e)
        {
            Accounting accountingForm= new Accounting();
            accountingForm.Show();
        }

        private void ReportsAndOutputs_Click(object sender, EventArgs e)
        {
            ReportsAndOutputs reportsAndOutputsForm = new ReportsAndOutputs();
            reportsAndOutputsForm.Show();
        }

        private void GetFastPayment_Click(object sender, EventArgs e)
        {
            GetFastPayment fastPaymentForm = new GetFastPayment();
            fastPaymentForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
