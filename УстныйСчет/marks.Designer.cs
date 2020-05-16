namespace УстныйСчет
{
    partial class marks
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.listView1 = new System.Windows.Forms.ListView();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(509, 28);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(33, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 211);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptyLabel.Location = new System.Drawing.Point(242, 143);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(74, 30);
            this.emptyLabel.TabIndex = 3;
            this.emptyLabel.Text = "(пусто)";
            this.emptyLabel.Visible = false;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(23, 287);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(519, 34);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Очистить журнал оценок";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 333);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroTile1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 333);
            this.Name = "marks";
            this.Text = "Журнал оценок";
            this.Shown += new System.EventHandler(this.marks_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label emptyLabel;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}