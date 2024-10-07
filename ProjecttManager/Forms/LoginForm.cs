using ProjecttManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecttManager
{
    public partial class LoginForm : Form
    {
        // Kullanıcı sınıfı
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        private List<User> users;

        public LoginForm()
        {
            users = new List<User>
            {
                new User { Username = "admin", Password = "admin123" },
                new User { Username = "user1", Password = "password1" },
                // Diğer kullanıcılar...
            };
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi kontrol et
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            User foundUser = users.Find(user => user.Username == enteredUsername);

            if (foundUser != null && foundUser.Password == enteredPassword)
            {
                // Kullanıcı doğrulandı, ana formu açabilirsiniz
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Giriş formunu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
