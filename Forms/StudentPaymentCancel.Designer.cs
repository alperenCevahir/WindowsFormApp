namespace KuzeyYildizi.Forms
{
    partial class StudentPaymentCancel
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
            this.paymentsDgv = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.CancelPaymentBtn = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.MonthsCmBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsDgv
            // 
            this.paymentsDgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.paymentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDgv.Location = new System.Drawing.Point(12, 185);
            this.paymentsDgv.Name = "paymentsDgv";
            this.paymentsDgv.RowHeadersWidth = 51;
            this.paymentsDgv.RowTemplate.Height = 29;
            this.paymentsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentsDgv.Size = new System.Drawing.Size(820, 188);
            this.paymentsDgv.TabIndex = 0;
            this.paymentsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentsDgv_CellContentClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 27);
            this.nameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğrenci İsmi";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterBtn.Location = new System.Drawing.Point(290, 141);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(264, 38);
            this.FilterBtn.TabIndex = 13;
            this.FilterBtn.Text = "Filtrele";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // CancelPaymentBtn
            // 
            this.CancelPaymentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelPaymentBtn.Location = new System.Drawing.Point(290, 379);
            this.CancelPaymentBtn.Name = "CancelPaymentBtn";
            this.CancelPaymentBtn.Size = new System.Drawing.Size(264, 38);
            this.CancelPaymentBtn.TabIndex = 14;
            this.CancelPaymentBtn.Text = "Ödemeyi İptal Et";
            this.CancelPaymentBtn.UseVisualStyleBackColor = true;
            this.CancelPaymentBtn.Click += new System.EventHandler(this.CancelPaymentBtn_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(567, 48);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(265, 27);
            this.surnameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(567, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Öğrenci Soyismi";
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(237, 84);
            this.YearTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.PlaceholderText = "Yıl Giriniz";
            this.YearTxt.Size = new System.Drawing.Size(190, 27);
            this.YearTxt.TabIndex = 17;
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
            this.MonthsCmBox.Location = new System.Drawing.Point(433, 83);
            this.MonthsCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MonthsCmBox.Name = "MonthsCmBox";
            this.MonthsCmBox.Size = new System.Drawing.Size(190, 28);
            this.MonthsCmBox.TabIndex = 18;
            this.MonthsCmBox.Text = "Ay Seçiniz";
            // 
            // StudentPaymentCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 423);
            this.Controls.Add(this.MonthsCmBox);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.CancelPaymentBtn);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.paymentsDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentPaymentCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ödeme İptali";
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView paymentsDgv;
        private TextBox nameTextBox;
        private Label label1;
        private Button FilterBtn;
        private Button CancelPaymentBtn;
        private TextBox surnameTextBox;
        private Label label2;
        private TextBox YearTxt;
        private ComboBox MonthsCmBox;
    }
}