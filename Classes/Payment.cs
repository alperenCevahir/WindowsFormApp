using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace KuzeyYildizi.Classes
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
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

        public Payment( Student student, int total, int installment, string paymentWeek)
        {
            
            Student = student;
            StudentId = student.TcNo;
            Total = total;
            Installment = installment;
            PaymentWeek = paymentWeek;
        }
    }
}
