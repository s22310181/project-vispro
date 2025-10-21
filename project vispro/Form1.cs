using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimeManager
{
    public class Form1 : Form
    {
        private Button btnSchedule, btnTips, btnExit;

        public Form1()
        {
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "Menu Pilihan";
            this.Size = new Size(800, 600);
            this.BackColor = Color.FromArgb(235, 215, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label()
            {
                Text = "📚 Menu Pilihan",
                Font = new Font("Poppins", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 30, 140),
                AutoSize = true,
                Location = new Point(270, 60)
            };
            Controls.Add(lblTitle);

            btnSchedule = new Button()
            {
                Text = "Jadwal Belajar",
                Size = new Size(200, 60),
                Location = new Point(300, 200),
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnSchedule.Click += (s, e) => { new Form2().Show(); };
            Controls.Add(btnSchedule);

            btnTips = new Button()
            {
                Text = "Tips Belajar",
                Size = new Size(200, 60),
                Location = new Point(300, 280),
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnTips.Click += (s, e) => { new Form3().Show(); };
            Controls.Add(btnTips);

            btnExit = new Button()
            {
                Text = "Keluar",
                Size = new Size(200, 60),
                Location = new Point(300, 360),
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnExit.Click += (s, e) => { Application.Exit(); };
            Controls.Add(btnExit);
        }
    }
}
