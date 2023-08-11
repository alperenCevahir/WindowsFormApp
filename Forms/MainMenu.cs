using KuzeyYildizi.Classes;
using KuzeyYildizi.Forms;
using Microsoft.Data.SqlClient;
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
        private string username;
        public MainMenu(string username)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.KY_LOGO;
            this.username = username;

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
            if (username == "misafir")
            {
                Accounting.Enabled = false;
                ReportsAndOutputs.Enabled = false;
                StudentUpdateDelete.Enabled = false;
                backUpBtn.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentUpdateDelete frm = new StudentUpdateDelete();
            frm.Show();
        }

        private void backUpBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Yedekleme Yerini Seçiniz.";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = folderBrowserDialog.SelectedPath;

                    try
                    {
                        using (MyDbContext dbContext = new MyDbContext())
                        {
                            dbContext.BackupDatabase(backupPath);
                        }

                        MessageBox.Show("Veritabanı başarı ile yedeklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yedekleme sırasında hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }
}
