using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class Payments
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public virtual Student? Student { get; set; } // Navigation property

    }
}
