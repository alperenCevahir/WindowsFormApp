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
        private int _tcNo;

        [Key]
        public int TcNo
        {
            get { return _tcNo; }
            set
            {
                if (value.ToString().Length == 11)
                {
                    _tcNo = value;
                }
                else
                {
                    throw new ArgumentException("TcNo must be 11 digits.");
                }
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsFatherAlive { get; set; }
        public bool IsMotherAlive { get; set; }     
        private int? _telNo;
        public int? TelNo
        {
            get { return _telNo; }
            set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentException("The TelNo must be 10 digits long.");
                }
                _telNo = value;
            }
        }
        public int StudentGrade { get; set; }
        public string StudentClass { get; set; }
        public string BirthPlaceAndYear { get; set; }
        public bool StudentGender { get; set; }
        public DateTime StartDate { get; set; }
        public string BloodType { get; set; }
        public string? Diseases { get; set; }
        public string? Medicines { get; set; }
        public string School { get; set; }
        public string Emergency1NameSurname {get; set; }
        public int Emergency1TelNo { get; set; }
        public string Emergency1Relativity { get; set; }
        public string Emergency2NameSurname { get; set; }
        public int Emergency2TelNo { get; set; }
        public string Emergency2Relativity { get; set; }

        public string Emergency3NameSurname { get; set; }
        public int Emergency3TelNo { get; set; }
        public string Emergency3Relativity { get; set; }




        public Student(string Name, string Surname, int TcNo, bool IsFatherAlive, bool IsMotherAlive, int TelNo
            ,int StudentGrade, string BirthPlaceAndYear, DateTime StartDate, string BloodType, string Diseases,
            string Medicines, string School, string Emergency1NameSurname, string Emergency2NameSurname,
            string Emergency3NameSurname, int Emergency1TelNo, int Emergency2TelNo, int Emergency3TelNo
            , string Emergency1Relativity, string Emergency2Relativity, string Emergency3Relativity)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.TcNo = TcNo;
            this.IsFatherAlive = IsFatherAlive;
            this.IsMotherAlive = IsMotherAlive;
            this.TelNo = TelNo;
            this.StudentGrade = StudentGrade;
            this.BirthPlaceAndYear = BirthPlaceAndYear;
            this.StartDate = StartDate;
            this.BloodType = BloodType;
            this.Diseases = Diseases;
            this.Medicines = Medicines;
            this.School = School;
            this.Emergency1NameSurname = Emergency1NameSurname;
            this.Emergency2NameSurname = Emergency2NameSurname;
            this.Emergency3NameSurname = Emergency3NameSurname;
            this.Emergency1TelNo = Emergency1TelNo;
            this.Emergency2TelNo = Emergency2TelNo;
            this.Emergency3TelNo = Emergency3TelNo;
            this.Emergency1Relativity = Emergency1Relativity;
            this.Emergency2Relativity = Emergency2Relativity;
            this.Emergency3Relativity = Emergency3Relativity;
        }

    }
}
