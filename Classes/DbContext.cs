using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KuzeyYildizi.Classes
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Custodian> Custodians { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alperen\source\repos\KuzeyYildizi\KuzeyYildiziDB.mdf;Integrated Security=True"" providerName=""System.Data.SqlClient");
        }
        
    }
}
