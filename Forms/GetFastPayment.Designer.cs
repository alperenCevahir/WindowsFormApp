namespace KuzeyYildizi.Forms
{
    partial class GetFastPayment
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
            this.NameSurnameTxt = new System.Windows.Forms.TextBox();
            this.ClassCmBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.TakePaymentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WhoIsPayingTxt = new System.Windows.Forms.TextBox();
            this.PaymentAmountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PaymentDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // NameSurnameTxt
            // 
            this.NameSurnameTxt.Location = new System.Drawing.Point(417, 76);
            this.NameSurnameTxt.Name = "NameSurnameTxt";
            this.NameSurnameTxt.Size = new System.Drawing.Size(264, 27);
            this.NameSurnameTxt.TabIndex = 0;
            // 
            // ClassCmBox
            // 
            this.ClassCmBox.FormattingEnabled = true;
            this.ClassCmBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ClassCmBox.Location = new System.Drawing.Point(417, 157);
            this.ClassCmBox.Name = "ClassCmBox";
            this.ClassCmBox.Size = new System.Drawing.Size(264, 28);
            this.ClassCmBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(417, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sınıfı";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(417, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(264, 43);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(43, 283);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 29;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(984, 188);
            this.dgvResults.TabIndex = 6;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // TakePaymentBtn
            // 
            this.TakePaymentBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakePaymentBtn.Location = new System.Drawing.Point(417, 535);
            this.TakePaymentBtn.Name = "TakePaymentBtn";
            this.TakePaymentBtn.Size = new System.Drawing.Size(264, 43);
            this.TakePaymentBtn.TabIndex = 7;
            this.TakePaymentBtn.Text = "Ödeme Al";
            this.TakePaymentBtn.UseVisualStyleBackColor = true;
            this.TakePaymentBtn.Click += new System.EventHandler(this.TakePaymentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ödeme Yapan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WhoIsPayingTxt
            // 
            this.WhoIsPayingTxt.Location = new System.Drawing.Point(206, 477);
            this.WhoIsPayingTxt.Name = "WhoIsPayingTxt";
            this.WhoIsPayingTxt.Size = new System.Drawing.Size(181, 27);
            this.WhoIsPayingTxt.TabIndex = 9;
            // 
            // PaymentAmountTxt
            // 
            this.PaymentAmountTxt.Location = new System.Drawing.Point(479, 477);
            this.PaymentAmountTxt.Name = "PaymentAmountTxt";
            this.PaymentAmountTxt.Size = new System.Drawing.Size(181, 27);
            this.PaymentAmountTxt.TabIndex = 10;
            this.PaymentAmountTxt.TextChanged += new System.EventHandler(this.PaymentAmountTxt_TextChanged);
            this.PaymentAmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentAmountTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(393, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miktar";
            // 
            // PaymentDateDTP
            // 
            this.PaymentDateDTP.CustomFormat = "dd.MM.yyyy";
            this.PaymentDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PaymentDateDTP.Location = new System.Drawing.Point(846, 478);
            this.PaymentDateDTP.Name = "PaymentDateDTP";
            this.PaymentDateDTP.Size = new System.Drawing.Size(181, 27);
            this.PaymentDateDTP.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(691, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ödeme Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(287, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(522, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Normal taksit miktarını almak için miktar kısmını boş bırakabilirsiniz.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GetFastPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1059, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaymentDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentAmountTxt);
            this.Controls.Add(this.WhoIsPayingTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TakePaymentBtn);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassCmBox);
            this.Controls.Add(this.NameSurnameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GetFastPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Ödeme Al";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameSurnameTxt;
        private ComboBox ClassCmBox;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private DataGridView dgvResults;
        private Button TakePaymentBtn;
        private Label label1;
        private TextBox WhoIsPayingTxt;
        private TextBox PaymentAmountTxt;
        private Label label4;
        public DateTimePicker PaymentDateDTP;
        private Label label5;
        private Label label6;
    }
}