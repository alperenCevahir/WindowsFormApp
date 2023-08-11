using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace KuzeyYildizi.Classes
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Payments> payments { get; set; }
        public DbSet<Income> incomes { get; set; }
        public DbSet<Expense> expenses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string databaseName = "KuzeyYildiziData";
                string databaseFileName = $"{databaseName}.mdf"; // Database file name with the extension
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Ensure the directory exists
                Directory.CreateDirectory(exeDirectory);
                string databaseFilePath = Path.Combine(exeDirectory, databaseFileName);

                // Check if the database file exists at the specified location
                if (!File.Exists(databaseFilePath))
                {
                    // Handle the case when the database file is not found.
                    // You can copy the database file from a known location or show an error message to the user.
                    // For simplicity, let's display an error message and exit the application.
                    MessageBox.Show("Database file not found. Make sure the database file is placed in the same directory as the executable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                string connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public void BackupDatabase(string backupPath)
        {
            string databaseName = "KuzeyYildiziData"; // Replace with the actual name of your database without the file extension
            string databaseNameLog = "KuzeyYildiziData_log"; // Replace with the actual name of your database without the file extension
            string databaseFileNameLog = $"{databaseNameLog}.ldf"; // Database file name with the extension

            string databaseFileName = $"{databaseName}.mdf"; // Database file name with the extension
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string databaseFilePath = Path.Combine(exeDirectory, databaseFileName);
            string databaseFilePathLog = Path.Combine(exeDirectory, databaseFileNameLog);
            string destinationFilePath = System.IO.Path.Combine(backupPath, databaseFileName);
            string destinationFilePathLog = System.IO.Path.Combine(backupPath, databaseFileNameLog);

            File.Copy(databaseFilePathLog, destinationFilePathLog, true);
            File.Copy(databaseFilePath, destinationFilePath, true);

        }
    }
}
