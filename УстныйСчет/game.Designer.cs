namespace УстныйСчет
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.solutionTimer = new System.Windows.Forms.Timer(this.components);
            this.numsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(584, 24);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(33, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // solutionTimer
            // 
            this.solutionTimer.Interval = 30000;
            this.solutionTimer.Tick += new System.EventHandler(this.solutionTimer_Tick);
            // 
            // numsLabel
            // 
            this.numsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numsLabel.AutoSize = true;
            this.numsLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numsLabel.Location = new System.Drawing.Point(14, 79);
            this.numsLabel.Name = "numsLabel";
            this.numsLabel.Size = new System.Drawing.Size(92, 30);
            this.numsLabel.TabIndex = 2;
            this.numsLabel.Text = "Пример:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(223, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 24.75F);
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пример ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ответ:";
            // 
            // metroTile2
            // 
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Location = new System.Drawing.Point(223, 157);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(50, 56);
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "7";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.Location = new System.Drawing.Point(279, 157);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(50, 56);
            this.metroTile3.TabIndex = 9;
            this.metroTile3.Text = "8";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile4.Location = new System.Drawing.Point(335, 157);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(50, 56);
            this.metroTile4.TabIndex = 10;
            this.metroTile4.Text = "9";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile5.Location = new System.Drawing.Point(335, 219);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(50, 56);
            this.metroTile5.TabIndex = 13;
            this.metroTile5.Text = "6";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile6.Location = new System.Drawing.Point(279, 219);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(50, 56);
            this.metroTile6.TabIndex = 12;
            this.metroTile6.Text = "5";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile7.Location = new System.Drawing.Point(223, 219);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(50, 56);
            this.metroTile7.TabIndex = 11;
            this.metroTile7.Text = "4";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile8.Location = new System.Drawing.Point(335, 281);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(50, 56);
            this.metroTile8.TabIndex = 16;
            this.metroTile8.Text = "3";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile9.Location = new System.Drawing.Point(279, 281);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(50, 56);
            this.metroTile9.TabIndex = 15;
            this.metroTile9.Text = "2";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // metroTile10
            // 
            this.metroTile10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile10.Location = new System.Drawing.Point(223, 281);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(50, 56);
            this.metroTile10.TabIndex = 14;
            this.metroTile10.Text = "1";
            this.metroTile10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile10.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile10.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile10.Click += new System.EventHandler(this.metroTile10_Click);
            // 
            // metroTile11
            // 
            this.metroTile11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile11.Location = new System.Drawing.Point(414, 343);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(203, 56);
            this.metroTile11.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile11.TabIndex = 17;
            this.metroTile11.Text = "OK";
            this.metroTile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile11.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile11.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile11.Click += new System.EventHandler(this.metroTile11_Click);
            // 
            // metroTile13
            // 
            this.metroTile13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile13.Location = new System.Drawing.Point(223, 343);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(50, 56);
            this.metroTile13.TabIndex = 19;
            this.metroTile13.Text = "0";
            this.metroTile13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile13.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile13.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile13.Click += new System.EventHandler(this.metroTile13_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(409, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Таймер:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 21;
            this.label4.Text = "30";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(409, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Вердикт:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(405, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "(нет данных)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(461, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 50);
            this.label7.TabIndex = 24;
            this.label7.Text = "сек.";
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label8.Location = new System.Drawing.Point(13, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 37);
            this.label8.TabIndex = 25;
            this.label8.Text = "Вопрос 0/0";
            // 
            // metroTile12
            // 
            this.metroTile12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile12.Location = new System.Drawing.Point(279, 343);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(50, 56);
            this.metroTile12.TabIndex = 27;
            this.metroTile12.Text = "-";
            this.metroTile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile12.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile12.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile12.Click += new System.EventHandler(this.metroTile12_Click);
            // 
            // metroTile14
            // 
            this.metroTile14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile14.Location = new System.Drawing.Point(335, 343);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(50, 56);
            this.metroTile14.TabIndex = 28;
            this.metroTile14.Text = "<";
            this.metroTile14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile14.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile14.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile14.Click += new System.EventHandler(this.metroTile14_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 72F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(198, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 128);
            this.label9.TabIndex = 29;
            this.label9.Text = "END";
            this.label9.Visible = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metroTile14);
            this.Controls.Add(this.metroTile12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile13);
            this.Controls.Add(this.metroTile11);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile9);
            this.Controls.Add(this.metroTile10);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numsLabel);
            this.Controls.Add(this.metroTile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "game";
            this.Text = "Устный счет: игра";
            this.Shown += new System.EventHandler(this.game_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Timer solutionTimer;
        private System.Windows.Forms.Label numsLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile metroTile14;
        private System.Windows.Forms.Label label9;
    }
}