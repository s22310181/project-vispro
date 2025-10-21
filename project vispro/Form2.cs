using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimeManager
{
    public class Form2 : Form
    {
        private DataGridView dgv;
        private Timer studyTimer;
        private Label lblTimer;
        private int seconds = 0;

        public Form2()
        {
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "Jadwal Belajar";
            this.Size = new Size(800, 600);
            this.BackColor = Color.FromArgb(240, 225, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label title = new Label()
            {
                Text = "📅 Jadwal Belajar Mingguan",
                Font = new Font("Poppins", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(90, 40, 140),
                AutoSize = true,
                Location = new Point(220, 20)
            };
            Controls.Add(title);

            dgv = new DataGridView()
            {
                Size = new Size(700, 300),
                Location = new Point(50, 80),
                BackgroundColor = Color.White,
                ReadOnly = true
            };
            dgv.Columns.Add("Day", "Hari");
            dgv.Columns.Add("Subject", "Mata Pelajaran");
            dgv.Columns.Add("Time", "Waktu");

            dgv.Rows.Add("Senin", "Visual Programming", "08:00 - 10:00");
            dgv.Rows.Add("Selasa", "Computer Networking", "10:00 - 12:00");
            dgv.Rows.Add("Rabu", "Operating System", "13:00 - 15:00");
            dgv.Rows.Add("Kamis", "SAD", "09:00 - 11:00");
            dgv.Rows.Add("Jumat", "Front-End", "08:30 - 10:30");
            Controls.Add(dgv);

            lblTimer = new Label()
            {
                Text = "⏰ Waktu Belajar: 00:00",
                Location = new Point(50, 400),
                Font = new Font("Consolas", 14, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(90, 40, 140)
            };
            Controls.Add(lblTimer);

            studyTimer = new Timer();
            studyTimer.Interval = 1000;
            studyTimer.Tick += StudyTimer_Tick;
            studyTimer.Start();
        }

        private void StudyTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = $"⏰ Waktu Belajar: {seconds / 60:D2}:{seconds % 60:D2}";
        }
    }
}
