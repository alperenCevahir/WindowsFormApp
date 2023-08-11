using KuzeyYildizi.Classes;
using System.Net;

namespace KuzeyYildizi
{
    public partial class Login : Form
    {
        User user;

        List<User> users = User.LoadUsersFromFile("users.txt");
        private bool isCredentialsValid;
        public bool IsCredentialsValid
        {
            get { return isCredentialsValid; }
        }
        public string username { get; private set; }

        public Login()
        {
            InitializeComponent();

            // Set the Image property of the PictureBox to the resource named "myimage"
            pictureBox1.Image = Properties.Resources.KY_LOGO;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void signInLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Lütfen kullanýcý adýnýzý giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen þifrenizi giriniz.");
                return;
            }

            
            // Find the user with the matching username and password
            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);


            if (user != null)
            {
                this.isCredentialsValid = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
                //program.cs controls the main menu openning

               
            }
            else
            {
                // The user was not found - display an error message
                MessageBox.Show("Geçersiz Kullanýcý Adý veya Þifre.");
            }
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public string GetUsername()
        {
            return username;
        }
    }
}