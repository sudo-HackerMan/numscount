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
    public partial class marks : MetroFramework.Forms.MetroForm
    {
        public marks()
        {
            InitializeComponent();

            if (File.Exists("marks"))
            {
                for (int i = 0; i < File.ReadAllLines("marks").Length; i++)
                {
                    listView1.Items.Add(File.ReadAllLines("marks")[i]);
                }
            }
            
            else
            {
                emptyLabel.Visible = true;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Visible = false;           
        }

        private void marks_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("settings.conf");
            string theme = sr.ReadLine();
            sr.Close();
            if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                listView1.BackColor = Color.FromArgb(17, 17, 17);
                listView1.ForeColor = Color.White;
                emptyLabel.ForeColor = Color.White;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (File.Exists("marks"))
            {
                File.Delete("marks");
            }
            emptyLabel.Visible = true;
            listView1.Clear();
        }
    }
}
