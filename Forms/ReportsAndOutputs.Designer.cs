namespace KuzeyYildizi.Forms
{
    partial class ReportsAndOutputs
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
            this.TotalStudentNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassStudentNumbers = new System.Windows.Forms.Button();
            this.MontlhyPaidStudents = new System.Windows.Forms.Button();
            this.MontlhyUnpaidStudents = new System.Windows.Forms.Button();
            this.MonthlyExpense = new System.Windows.Forms.Button();
            this.MonthlyIncome = new System.Windows.Forms.Button();
            this.ReportsDgv = new System.Windows.Forms.DataGridView();
            this.MonthsCmBox = new System.Windows.Forms.ComboBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.IncomeCmBox = new System.Windows.Forms.ComboBox();
            this.ExpenseCmBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalStudentNumber
            // 
            this.TotalStudentNumber.Location = new System.Drawing.Point(90, 80);
            this.TotalStudentNumber.Name = "TotalStudentNumber";
            this.TotalStudentNumber.Size = new System.Drawing.Size(400, 53);
            this.TotalStudentNumber.TabIndex = 2;
            this.TotalStudentNumber.Text = "Toplam Öğrenci Sayısı";
            this.TotalStudentNumber.UseVisualStyleBackColor = true;
            this.TotalStudentNumber.Click += new System.EventHandler(this.TotalStudentNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raporlar ve Çıktılar";
            // 
            // ClassStudentNumbers
            // 
            this.ClassStudentNumbers.Location = new System.Drawing.Point(527, 80);
            this.ClassStudentNumbers.Name = "ClassStudentNumbers";
            this.ClassStudentNumbers.Size = new System.Drawing.Size(400, 53);
            this.ClassStudentNumbers.TabIndex = 5;
            this.ClassStudentNumbers.Text = "Sınıf Öğrenci Mevcutları";
            this.ClassStudentNumbers.UseVisualStyleBackColor = true;
            this.ClassStudentNumbers.Click += new System.EventHandler(this.ClassStudentNumbers_Click);
            // 
            // MontlhyPaidStudents
            // 
            this.MontlhyPaidStudents.Location = new System.Drawing.Point(527, 163);
            this.MontlhyPaidStudents.Name = "MontlhyPaidStudents";
            this.MontlhyPaidStudents.Size = new System.Drawing.Size(191, 53);
            this.MontlhyPaidStudents.TabIndex = 6;
            this.MontlhyPaidStudents.Text = "Aylık Ödeme Yapan Öğrenciler";
            this.MontlhyPaidStudents.UseVisualStyleBackColor = true;
            this.MontlhyPaidStudents.Click += new System.EventHandler(this.MontlhyPaidStudents_Click);
            // 
            // MontlhyUnpaidStudents
            // 
            this.MontlhyUnpaidStudents.Location = new System.Drawing.Point(736, 163);
            this.MontlhyUnpaidStudents.Name = "MontlhyUnpaidStudents";
            this.MontlhyUnpaidStudents.Size = new System.Drawing.Size(191, 53);
            this.MontlhyUnpaidStudents.TabIndex = 7;
            this.MontlhyUnpaidStudents.Text = "Aylık Ödeme Yapmayan Öğrenciler";
            this.MontlhyUnpaidStudents.UseVisualStyleBackColor = true;
            this.MontlhyUnpaidStudents.Click += new System.EventHandler(this.MontlhyUnpaidStudents_Click);
            // 
            // MonthlyExpense
            // 
            this.MonthlyExpense.Location = new System.Drawing.Point(527, 264);
            this.MonthlyExpense.Name = "MonthlyExpense";
            this.MonthlyExpense.Size = new System.Drawing.Size(400, 53);
            this.MonthlyExpense.TabIndex = 8;
            this.MonthlyExpense.Text = "Aylık Gider";
            this.MonthlyExpense.UseVisualStyleBackColor = true;
            this.MonthlyExpense.Click += new System.EventHandler(this.MonthlyExpense_Click);
            // 
            // MonthlyIncome
            // 
            this.MonthlyIncome.Location = new System.Drawing.Point(89, 264);
            this.MonthlyIncome.Name = "MonthlyIncome";
            this.MonthlyIncome.Size = new System.Drawing.Size(400, 53);
            this.MonthlyIncome.TabIndex = 9;
            this.MonthlyIncome.Text = "Aylık Gelir";
            this.MonthlyIncome.UseVisualStyleBackColor = true;
            this.MonthlyIncome.Click += new System.EventHandler(this.MonthlyIncome_Click);
            // 
            // ReportsDgv
            // 
            this.ReportsDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReportsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsDgv.Location = new System.Drawing.Point(90, 333);
            this.ReportsDgv.Name = "ReportsDgv";
            this.ReportsDgv.ReadOnly = true;
            this.ReportsDgv.RowHeadersWidth = 51;
            this.ReportsDgv.RowTemplate.Height = 29;
            this.ReportsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportsDgv.Size = new System.Drawing.Size(837, 459);
            this.ReportsDgv.TabIndex = 10;
            // 
            // MonthsCmBox
            // 
            this.MonthsCmBox.FormattingEnabled = true;
            this.MonthsCmBox.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.MonthsCmBox.Location = new System.Drawing.Point(299, 176);
            this.MonthsCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MonthsCmBox.Name = "MonthsCmBox";
            this.MonthsCmBox.Size = new System.Drawing.Size(190, 28);
            this.MonthsCmBox.TabIndex = 11;
            this.MonthsCmBox.Text = "Ay Seçiniz";
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(90, 176);
            this.YearTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.PlaceholderText = "Yıl Giriniz";
            this.YearTxt.Size = new System.Drawing.Size(190, 27);
            this.YearTxt.TabIndex = 12;
            this.YearTxt.TextChanged += new System.EventHandler(this.YearTxt_TextChanged);
            this.YearTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTxt_KeyPress);
            // 
            // IncomeCmBox
            // 
            this.IncomeCmBox.FormattingEnabled = true;
            this.IncomeCmBox.Items.AddRange(new object[] {
            "Toplam",
            "Öğrenci Ödeme Alma",
            "Özel Ders Ödeme Alma",
            "Ekstra Ödeme Alma",
            "Ödeme",
            "Diğer"});
            this.IncomeCmBox.Location = new System.Drawing.Point(212, 229);
            this.IncomeCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncomeCmBox.Name = "IncomeCmBox";
            this.IncomeCmBox.Size = new System.Drawing.Size(190, 28);
            this.IncomeCmBox.TabIndex = 13;
            this.IncomeCmBox.Text = "Gelir Tipi Seçiniz";
            this.IncomeCmBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExpenseCmBox
            // 
            this.ExpenseCmBox.FormattingEnabled = true;
            this.ExpenseCmBox.Items.AddRange(new object[] {
            "Toplam",
            "Öğretmen Ödeme Yapma",
            "Fatura Ödeme",
            "Kredi Ödeme",
            "Sigorta Ödeme",
            "Vergi Ödeme",
            "Taksit Ödeme",
            "Market",
            "Diğer"});
            this.ExpenseCmBox.Location = new System.Drawing.Point(646, 229);
            this.ExpenseCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpenseCmBox.Name = "ExpenseCmBox";
            this.ExpenseCmBox.Size = new System.Drawing.Size(190, 28);
            this.ExpenseCmBox.TabIndex = 14;
            this.ExpenseCmBox.Text = "Gider Tipi Seçiniz";
            // 
            // ReportsAndOutputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1019, 819);
            this.Controls.Add(this.ExpenseCmBox);
            this.Controls.Add(this.IncomeCmBox);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.MonthsCmBox);
            this.Controls.Add(this.ReportsDgv);
            this.Controls.Add(this.MonthlyIncome);
            this.Controls.Add(this.MonthlyExpense);
            this.Controls.Add(this.MontlhyUnpaidStudents);
            this.Controls.Add(this.MontlhyPaidStudents);
            this.Controls.Add(this.ClassStudentNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalStudentNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsAndOutputs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar ve Çıktılar";
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TotalStudentNumber;
        private Label label2;
        private Button ClassStudentNumbers;
        private Button MontlhyPaidStudents;
        private Button MontlhyUnpaidStudents;
        private Button MonthlyExpense;
        private Button MonthlyIncome;
        private DataGridView ReportsDgv;
        private ComboBox MonthsCmBox;
        private TextBox YearTxt;
        private ComboBox IncomeCmBox;
        private ComboBox ExpenseCmBox;
    }
}