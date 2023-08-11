using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string? Type { get; set; }
        public string? Information { get; set; }

    }
}
