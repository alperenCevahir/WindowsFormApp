using KuzeyYildizi.Classes;
using Microsoft.Identity.Client;
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
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();
        }

        private void tcNoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tcNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StartingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = StartingDateTimePicker.Value;
        }

        private void GradeTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void GradeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MotherTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MotherTelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FatherTcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FatherTelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency1TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency2TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Emergency3TelNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TotalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        public abstract class SchoolFactory
        {
            public abstract Student CreateStudent();
            public abstract Payment CreatePayment(Student student);
            public abstract Custodian CreateMother(Student student);
            public abstract Custodian CreateFather(Student student);

        }
        
        public class AddStudentAndRelatedObjectsFactory : SchoolFactory
        {
            private AddStudent _form;

            public AddStudentAndRelatedObjectsFactory(AddStudent form)
            {
                _form = form;
            }
            public override Student CreateStudent()
            {
                // Create a new student object with the input values
                string Name = _form.nameTxt.Text;
                string Surname = _form.surnameTxt.Text;
                int TcNO = Int32.Parse(_form.tcNoTxt.Text);
                bool IsFatherAlive = !_form.FatherDeadCheckBox.Checked;
                bool IsMotherAlive = !_form.MotherDeadCheckBox.Checked;
                int TelNo = Int32.Parse(_form.TelNoTxt.Text);
                int StudentGrade = Int32.Parse(_form.GradeTxt.Text);
                string BirthPlaceAndYear = _form.BirthPlaceAndYearTxt.Text;
                DateTime StartDate = _form.StartingDateTimePicker.Value;
                string BloodType = _form.BloodTypeTxt.Text;
                string Diseases = _form.DiseaseTxt.Text;
                string Medicines = _form.MedicineTxt.Text;
                string School = _form.SchoolTxt.Text;

                string Emergency1NameSurname = _form.Emergency1NameTxtBox.Text + " " + _form.Emergency1SurnameTxtBox.Text;
                string Emergency2NameSurname = _form.Emergency2NameTxtBox.Text + " " + _form.Emergency2SurnameTxtBox.Text;
                string Emergency3NameSurname = _form.Emergency3NameTxtBox.Text + " " + _form.Emergency3SurnameTxtBox.Text;

                int Emergency1TelNo = Int32.Parse(_form.Emergency1TelNoTxtBox.Text);
                int Emergency2TelNo = Int32.Parse(_form.Emergency2TelNoTxtBox.Text);
                int Emergency3TelNo = Int32.Parse(_form.Emergency3TelNoTxtBox.Text);

                string Emergency1Relativity = _form.Emergency1RelativityTxtBox.Text;
                string Emergency2Relativity = _form.Emergency2RelativityTxtBox.Text;
                string Emergency3Relativity = _form.Emergency3RelativityTxtBox.Text;


                return new Student(Name,Surname,TcNO,IsFatherAlive,IsMotherAlive,TelNo,StudentGrade,BirthPlaceAndYear
                    ,StartDate,BloodType,Diseases,Medicines,School, Emergency1NameSurname, Emergency2NameSurname,
                    Emergency3NameSurname, Emergency1TelNo, Emergency2TelNo,Emergency3TelNo, Emergency1Relativity,
                    Emergency2Relativity, Emergency3Relativity);

            }
            public override Payment CreatePayment(Student student)
            {
                int total = Int32.Parse(_form.TotalTxt.Text);
                int installment = Int32.Parse(_form.InstallmentCmBox.Text);
                string paymentWeek = _form.PaymentWeekTxt.Text;
                return new Payment(student, total, installment, paymentWeek);
            }
            public override Custodian CreateMother(Student student)
            {
                // Create a new custodian object with the input values
                throw new NotImplementedException();
            }
            public override Custodian CreateFather(Student student)
            {
                // Create a new custodian object with the input values
                throw new NotImplementedException();
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // Create a new factory object
            SchoolFactory factory = new AddStudentAndRelatedObjectsFactory(this);
            // Use the factory to create a new student, payment, custodian, and emergency object
            Student newStudent = factory.CreateStudent();
            Payment newPayment = factory.CreatePayment(newStudent);
            Custodian newMother = factory.CreateMother(newStudent);
            Custodian newFather = factory.CreateFather(newStudent);            

            // Add the new student, payment, custodian, and emergency objects to your list or database
            // ...

            // Close the form or clear the input fields
        }
    }
}
