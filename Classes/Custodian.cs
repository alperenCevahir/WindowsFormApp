using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class Custodian
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
        public int StudentId { get; set; }
        public List<Student> Students { get; set; }

        public bool IsCustodian { get; set; }

        public bool IsFather { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

       

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

        public string Occupation { get; set; }

        public string Address { get; set; }

        public bool ParentsLiveTogether { get; set; }


    }
}
