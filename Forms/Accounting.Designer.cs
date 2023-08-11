namespace KuzeyYildizi.Forms
{
    partial class Accounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeBtn = new System.Windows.Forms.Button();
            this.ExpenseBtn = new System.Windows.Forms.Button();
            this.StudentPaymentCancel = new System.Windows.Forms.Button();
            this.TeacherPaymentCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(558, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muhasebe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tahsilat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(925, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yapısal İşlemler";
            // 
            // IncomeBtn
            // 
            this.IncomeBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeBtn.Location = new System.Drawing.Point(70, 118);
            this.IncomeBtn.Name = "IncomeBtn";
            this.IncomeBtn.Size = new System.Drawing.Size(264, 43);
            this.IncomeBtn.TabIndex = 8;
            this.IncomeBtn.Text = "Gelir";
            this.IncomeBtn.UseVisualStyleBackColor = true;
            this.IncomeBtn.Click += new System.EventHandler(this.IncomeBtn_Click);
            // 
            // ExpenseBtn
            // 
            this.ExpenseBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpenseBtn.Location = new System.Drawing.Point(70, 167);
            this.ExpenseBtn.Name = "ExpenseBtn";
            this.ExpenseBtn.Size = new System.Drawing.Size(264, 43);
            this.ExpenseBtn.TabIndex = 9;
            this.ExpenseBtn.Text = "Gider";
            this.ExpenseBtn.UseVisualStyleBackColor = true;
            this.ExpenseBtn.Click += new System.EventHandler(this.ExpenseBtn_Click);
            // 
            // StudentPaymentCancel
            // 
            this.StudentPaymentCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentPaymentCancel.Location = new System.Drawing.Point(879, 118);
            this.StudentPaymentCancel.Name = "StudentPaymentCancel";
            this.StudentPaymentCancel.Size = new System.Drawing.Size(264, 43);
            this.StudentPaymentCancel.TabIndex = 18;
            this.StudentPaymentCancel.Text = "Öğrenci Ödeme İptali";
            this.StudentPaymentCancel.UseVisualStyleBackColor = true;
            this.StudentPaymentCancel.Click += new System.EventHandler(this.StudentPaymentCancel_Click);
            // 
            // TeacherPaymentCancel
            // 
            this.TeacherPaymentCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherPaymentCancel.Location = new System.Drawing.Point(879, 167);
            this.TeacherPaymentCancel.Name = "TeacherPaymentCancel";
            this.TeacherPaymentCancel.Size = new System.Drawing.Size(264, 43);
            this.TeacherPaymentCancel.TabIndex = 19;
            this.TeacherPaymentCancel.Text = "Öğretmen Ödeme İptali";
            this.TeacherPaymentCancel.UseVisualStyleBackColor = true;
            this.TeacherPaymentCancel.Click += new System.EventHandler(this.TeacherPaymentCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(403, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 250);
            this.label5.TabIndex = 26;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1210, 409);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeacherPaymentCancel);
            this.Controls.Add(this.StudentPaymentCancel);
            this.Controls.Add(this.ExpenseBtn);
            this.Controls.Add(this.IncomeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Button IncomeBtn;
        private Button ExpenseBtn;
        private Button StudentPaymentCancel;
        private Button TeacherPaymentCancel;
        private Label label5;
    }
}