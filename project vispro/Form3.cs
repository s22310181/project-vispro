using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimeManager
{
    public class Form3 : Form
    {
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

            Label lblTitle = new Label()
            {
                Text = "💡 Tips Belajar Efektif",
                Font = new Font("Poppins", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 40, 140),
                Location = new Point(230, 30),
                AutoSize = true
            };
            Controls.Add(lblTitle);

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
        }
    }
}
