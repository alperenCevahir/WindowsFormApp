namespace KuzeyYildizi.Forms
{
    partial class ExpenseForm1
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
            this.labelll = new System.Windows.Forms.Label();
            this.ExpenseTypeCmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.NoteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelll.Location = new System.Drawing.Point(51, 36);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(114, 31);
            this.labelll.TabIndex = 6;
            this.labelll.Text = "Gider Tipi";
            // 
            // ExpenseTypeCmBox
            // 
            this.ExpenseTypeCmBox.FormattingEnabled = true;
            this.ExpenseTypeCmBox.Items.AddRange(new object[] {
            "Öğretmen Ödeme Yapma",
            "Fatura Ödeme",
            "Kredi Ödeme",
            "Sigorta Ödeme",
            "Vergi Ödeme",
            "Taksit Ödeme",
            "Market",
            "Diğer"});
            this.ExpenseTypeCmBox.Location = new System.Drawing.Point(51, 73);
            this.ExpenseTypeCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpenseTypeCmBox.Name = "ExpenseTypeCmBox";
            this.ExpenseTypeCmBox.Size = new System.Drawing.Size(263, 28);
            this.ExpenseTypeCmBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(435, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Miktar";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(435, 73);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(265, 27);
            this.AmountTxt.TabIndex = 9;
            // 
            // NoteTxt
            // 
            this.NoteTxt.Location = new System.Drawing.Point(50, 164);
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(265, 27);
            this.NoteTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Not";
            // 
            // AddExpenseBtn
            // 
            this.AddExpenseBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddExpenseBtn.Location = new System.Drawing.Point(247, 241);
            this.AddExpenseBtn.Name = "AddExpenseBtn";
            this.AddExpenseBtn.Size = new System.Drawing.Size(264, 43);
            this.AddExpenseBtn.TabIndex = 12;
            this.AddExpenseBtn.Text = "Gider Ekle";
            this.AddExpenseBtn.UseVisualStyleBackColor = true;
            this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // ExpenseForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 337);
            this.Controls.Add(this.AddExpenseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteTxt);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpenseTypeCmBox);
            this.Controls.Add(this.labelll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExpenseForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelll;
        private ComboBox ExpenseTypeCmBox;
        private Label label1;
        private TextBox AmountTxt;
        private TextBox NoteTxt;
        private Label label2;
        private Button AddExpenseBtn;
    }
}