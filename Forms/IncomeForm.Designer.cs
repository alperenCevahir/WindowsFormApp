namespace KuzeyYildizi.Forms
{
    partial class ExpenseForm
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
            this.IncomeTypeCmBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteTxt = new System.Windows.Forms.TextBox();
            this.AddIncomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncomeTypeCmBox
            // 
            this.IncomeTypeCmBox.FormattingEnabled = true;
            this.IncomeTypeCmBox.Items.AddRange(new object[] {
            "Öğrenci Ödeme Alma",
            "Özel Ders Ödeme Alma",
            "Ekstra Ödeme Alma",
            "Diğer"});
            this.IncomeTypeCmBox.Location = new System.Drawing.Point(51, 73);
            this.IncomeTypeCmBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncomeTypeCmBox.Name = "IncomeTypeCmBox";
            this.IncomeTypeCmBox.Size = new System.Drawing.Size(263, 28);
            this.IncomeTypeCmBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gelir Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(435, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Miktar";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(435, 73);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(265, 27);
            this.AmountTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not";
            // 
            // NoteTxt
            // 
            this.NoteTxt.Location = new System.Drawing.Point(50, 164);
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(265, 27);
            this.NoteTxt.TabIndex = 9;
            // 
            // AddIncomeBtn
            // 
            this.AddIncomeBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddIncomeBtn.Location = new System.Drawing.Point(247, 241);
            this.AddIncomeBtn.Name = "AddIncomeBtn";
            this.AddIncomeBtn.Size = new System.Drawing.Size(264, 43);
            this.AddIncomeBtn.TabIndex = 10;
            this.AddIncomeBtn.Text = "Gelir Ekle";
            this.AddIncomeBtn.UseVisualStyleBackColor = true;
            this.AddIncomeBtn.Click += new System.EventHandler(this.AddIncomeBtn_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 337);
            this.Controls.Add(this.AddIncomeBtn);
            this.Controls.Add(this.NoteTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IncomeTypeCmBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox IncomeTypeCmBox;
        private Label label3;
        private Label label1;
        private TextBox AmountTxt;
        private Label label2;
        private TextBox NoteTxt;
        private Button AddIncomeBtn;
    }
}