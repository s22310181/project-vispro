using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimeManager
{
    public class LoginForm : Form
    {
        private TextBox txtUsername, txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "Manajemen Waktu Belajar";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(230, 210, 250);

            Label lblTitle = new Label()
            {
                Text = "🕒 Manajemen Waktu Belajar",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(230, 80),
                ForeColor = Color.FromArgb(90, 40, 140)
            };
            Controls.Add(lblTitle);

            Label lblUser = new Label()
            {
                Text = "Username:",
                Location = new Point(280, 180),
                AutoSize = true
            };
            Controls.Add(lblUser);

            txtUsername = new TextBox()
            {
                Location = new Point(280, 200),
                Width = 250
            };
            Controls.Add(txtUsername);

            Label lblPass = new Label()
            {
                Text = "Password:",
                Location = new Point(280, 240),
                AutoSize = true
            };
            Controls.Add(lblPass);

            txtPassword = new TextBox()
            {
                Location = new Point(280, 260),
                Width = 250,
                PasswordChar = '*'
            };
            Controls.Add(txtPassword);

            btnLogin = new Button()
            {
                Text = "Login",
                BackColor = Color.FromArgb(140, 100, 210),
                ForeColor = Color.White,
                Location = new Point(330, 320),
                Width = 150,
                Height = 40
            };
            btnLogin.Click += BtnLogin_Click;
            Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                this.Hide();
                Form1 mainMenu = new Form1();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal");
            }
        }
    }
}
