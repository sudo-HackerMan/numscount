using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace УстныйСчет
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string theme, dif;

        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();

            if (theme == "theme=light")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }

            else if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }

            sr.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            game g = new game();
            g.Show();
            this.Visible = false;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            marks m = new marks();
            m.Show();
            this.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (welcomeLabel.Location.Y != 25)
            {
                welcomeLabel.Location = new Point(welcomeLabel.Location.X, welcomeLabel.Location.Y + 1);
            }

            else
            {
                timer2.Enabled = false;
            }
            timer2.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            welcomeLabel.Visible = false;
            timer3.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (File.Exists("marks"))
            {
                label2.Text = File.ReadAllLines("marks").Last();
            }

            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();

            if (theme == "theme=light")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                welcomeLabel.ForeColor = Color.Black;
            }

            else if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                welcomeLabel.ForeColor = Color.White;
            }

            sr.Close();

            timer2.Enabled = true;
            timer3.Enabled = true;
        }
    }
}
