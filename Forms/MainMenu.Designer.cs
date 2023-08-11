namespace KuzeyYildizi
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GetFastPayment = new System.Windows.Forms.Button();
            this.ReportsAndOutputs = new System.Windows.Forms.Button();
            this.NewEntry = new System.Windows.Forms.Button();
            this.Accounting = new System.Windows.Forms.Button();
            this.StudentUpdateDelete = new System.Windows.Forms.Button();
            this.backUpBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KuzeyYildizi.Properties.Resources.KY_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(299, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GetFastPayment
            // 
            this.GetFastPayment.Location = new System.Drawing.Point(299, 39);
            this.GetFastPayment.Name = "GetFastPayment";
            this.GetFastPayment.Size = new System.Drawing.Size(217, 53);
            this.GetFastPayment.TabIndex = 1;
            this.GetFastPayment.Text = "Hızlı Ödeme Al";
            this.GetFastPayment.UseVisualStyleBackColor = true;
            this.GetFastPayment.Click += new System.EventHandler(this.GetFastPayment_Click);
            // 
            // ReportsAndOutputs
            // 
            this.ReportsAndOutputs.Location = new System.Drawing.Point(522, 176);
            this.ReportsAndOutputs.Name = "ReportsAndOutputs";
            this.ReportsAndOutputs.Size = new System.Drawing.Size(217, 53);
            this.ReportsAndOutputs.TabIndex = 2;
            this.ReportsAndOutputs.Text = "Raporlar Ve Çıktılar";
            this.ReportsAndOutputs.UseVisualStyleBackColor = true;
            this.ReportsAndOutputs.Click += new System.EventHandler(this.ReportsAndOutputs_Click);
            // 
            // NewEntry
            // 
            this.NewEntry.Location = new System.Drawing.Point(76, 176);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(217, 53);
            this.NewEntry.TabIndex = 3;
            this.NewEntry.Text = "Yeni Kayıt";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // Accounting
            // 
            this.Accounting.Location = new System.Drawing.Point(299, 319);
            this.Accounting.Name = "Accounting";
            this.Accounting.Size = new System.Drawing.Size(217, 53);
            this.Accounting.TabIndex = 4;
            this.Accounting.Text = "Muhasebe";
            this.Accounting.UseVisualStyleBackColor = true;
            this.Accounting.Click += new System.EventHandler(this.Accounting_Click_1);
            // 
            // StudentUpdateDelete
            // 
            this.StudentUpdateDelete.Location = new System.Drawing.Point(571, 385);
            this.StudentUpdateDelete.Name = "StudentUpdateDelete";
            this.StudentUpdateDelete.Size = new System.Drawing.Size(217, 53);
            this.StudentUpdateDelete.TabIndex = 5;
            this.StudentUpdateDelete.Text = "Öğrenci Düzenleme, Silme";
            this.StudentUpdateDelete.UseVisualStyleBackColor = true;
            this.StudentUpdateDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // backUpBtn
            // 
            this.backUpBtn.Location = new System.Drawing.Point(12, 385);
            this.backUpBtn.Name = "backUpBtn";
            this.backUpBtn.Size = new System.Drawing.Size(217, 53);
            this.backUpBtn.TabIndex = 6;
            this.backUpBtn.Text = "Yedekle";
            this.backUpBtn.UseVisualStyleBackColor = true;
            this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 50);
            this.label5.TabIndex = 27;
            this.label5.Text = "Haftada 1 yedekleme \r\nyapmanız tavsiye edilir.\r\n";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuzeyYildizi.Properties.Resources.Solid_white;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backUpBtn);
            this.Controls.Add(this.StudentUpdateDelete);
            this.Controls.Add(this.Accounting);
            this.Controls.Add(this.NewEntry);
            this.Controls.Add(this.ReportsAndOutputs);
            this.Controls.Add(this.GetFastPayment);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button GetFastPayment;
        private Button ReportsAndOutputs;
        private Button NewEntry;
        private Button Accounting;
        private Button StudentUpdateDelete;
        private Button backUpBtn;
        private Label label5;
    }
}