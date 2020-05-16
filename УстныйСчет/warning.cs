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
    public partial class warning : MetroFramework.Forms.MetroForm
    {
        public warning()
        {
            String theme;
            InitializeComponent();
            TopMost = true;
            //StreamReader sr = new StreamReader("marks");
            label2.Text = $"Ваш результат {File.ReadAllLines("marks").Last()} был записан.";
            //sr.Close();

            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            
            if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                label2.ForeColor = Color.White;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
