using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class Emergency
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Relativity { get; set; }
        private int _telNo;
        public int TelNo
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
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
