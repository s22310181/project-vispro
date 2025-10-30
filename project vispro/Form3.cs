using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimeManager
{
    public class Form3 : Form
    {
        private Button btnBack, btnNext;

        public Form3()
        {
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "Tips Belajar";
            this.Size = new Size(800, 600);
            this.BackColor = Color.FromArgb(235, 215, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Judul
            Label lblTitle = new Label()
            {
                Text = "💡 Tips Belajar Efektif",
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 140),
                Location = new Point(230, 30),
                AutoSize = true
            };
            Controls.Add(lblTitle);

            // Daftar tips
            Label lblTips = new Label()
            {
                Text =
                    "1️⃣ Buat jadwal belajar teratur.\n\n" +
                    "2️⃣ Istirahat setiap 45 menit agar otak tetap fokus.\n\n" +
                    "3️⃣ Gunakan teknik Pomodoro untuk meningkatkan konsentrasi.\n\n" +
                    "4️⃣ Catat poin penting dan rangkum setelah belajar.\n\n" +
                    "5️⃣ Hindari belajar di tempat ramai dan bising.\n\n" +
                    "6️⃣ Gunakan warna dan visual agar mudah diingat.\n\n" +
                    "7️⃣ Jangan lupa berdoa sebelum belajar 🙏",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.Black,
                Location = new Point(100, 120),
                AutoSize = true
            };
            Controls.Add(lblTips);

            // Tombol Back
            btnBack = new Button()
            {
                Text = "⬅ Back",
                Location = new Point(50, 500),
                Size = new Size(120, 40),
                BackColor = Color.FromArgb(180, 120, 230),
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold)
            };
            btnBack.Click += BtnBack_Click;
            Controls.Add(btnBack);

            // Tombol Next
            btnNext = new Button()
            {
                Text = "Next ➡",
                Location = new Point(620, 500),
                Size = new Size(120, 40),
                BackColor = Color.FromArgb(140, 100, 210),
                ForeColor = Color.White,
                Font = new Font("Poppins", 10, FontStyle.Bold)
            };
            btnNext.Click += BtnNext_Click;
            Controls.Add(btnNext);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Kembali ke Form2 (Jadwal Belajar)
            this.Hide();
            Form2 jadwal = new Form2();
            jadwal.Show();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Misalnya ke halaman login lagi (bisa diganti form lain)
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
