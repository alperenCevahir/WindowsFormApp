namespace KuzeyYildizi
{
    internal static class Program
    {
        //https://github.com/alperenCevahir
        //Tüm satýþ haklarý Alperen Cevahiroðlu þahsýna aittir.
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the login form and display it as a dialog box
            Login loginForm = new Login();
            DialogResult result = loginForm.ShowDialog();
            // If the user clicked the login button and their credentials are valid, show the main menu form
            if (result == DialogResult.OK && loginForm.IsCredentialsValid)
            {
                string username = loginForm.GetUsername(); // Retrieve the username
                Application.Run(new MainMenu(username));
            }
        }
    }
}