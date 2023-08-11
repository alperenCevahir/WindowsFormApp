using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //Student Info
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? TelNo { get; set; }
        public int StudentGrade { get; set; }
        public string BirthPlaceAndYear { get; set; }
        public string StudentGender { get; set; }
        public DateTime StartDate { get; set; }
        public string? BloodType { get; set; }
        public string? Diseases { get; set; }
        public string? Medicines { get; set; }
        public string School { get; set; }
        public bool IncludeFood { get; set; }

        //Parents Infos
        public bool IsFatherAlive { get; set; }
        public bool IsMotherAlive { get; set; }  
        public string? MotherTc { get; set; }
        public string? FatherTc { get; set; }
        public string MotherIsCustodian { get; set; }
        public string FatherIsCustodian { get; set; }
        public bool ParentsLiveTogether { get; set; }
        public string MotherNameSurname { get; set; }
        public string FatherNameSurname { get; set; }
        public string MotherTelNo { get; set; }
        public string FatherTelNo { get; set; }
        public string? MotherOccupation { get; set; }
        public string? FatherOccupation { get; set; }
        public string MotherAddress { get; set; }
        public string FatherAddress { get; set; }
        
        //Payment Info
        public int Total { get; set; }
        public int Installment { get; set; }
        public decimal MonthlyAmount
        {
            get
            {
                if (Installment == 0)
                {
                    return Total;
                }
                else
                {
                    return Total / Installment;
                }
            }
        }
        public string PaymentWeek { get; set; }
        public bool Cash { get; set; }
        public bool CreditCard { get; set; }
        public bool Transfer { get; set; }
        public int PaidInstallment { get; set; }
        public void IncreaseInstallment()
        {
            PaidInstallment++;
        }


        //Emergency Infos
        public string? Emergency1NameSurname {get; set; }
        public string? Emergency1TelNo { get; set; }
        public string? Emergency1Relativity { get; set; }
        public string? Emergency2NameSurname { get; set; }
        public string? Emergency2TelNo { get; set; }
        public string? Emergency2Relativity { get; set; }

        public string? Emergency3NameSurname { get; set; }
        public string? Emergency3TelNo { get; set; }
        public string? Emergency3Relativity { get; set; }


        public void SaveChangesToDatabase()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    Student student = context.students.Find(this.Id); // Replace Id with the actual student identifier
                    if (student != null)
                    {
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions that may occur during saving changes
                    Console.WriteLine("Error saving changes to the database: " + ex.Message);
                }
            }
        }


    }
}
