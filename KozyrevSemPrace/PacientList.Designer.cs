namespace KozyrevSemPrace
{
    partial class PacientList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.info = new System.Windows.Forms.Button();
            this.smazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 573);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 608);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(233, 40);
            this.info.TabIndex = 1;
            this.info.Text = "INFORMACE";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // smazat
            // 
            this.smazat.Location = new System.Drawing.Point(251, 608);
            this.smazat.Name = "smazat";
            this.smazat.Size = new System.Drawing.Size(233, 40);
            this.smazat.TabIndex = 2;
            this.smazat.Text = "SMAZAT";
            this.smazat.UseVisualStyleBackColor = true;
            this.smazat.Click += new System.EventHandler(this.smazat_Click);
            // 
            // PacientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 662);
            this.Controls.Add(this.smazat);
            this.Controls.Add(this.info);
            this.Controls.Add(this.listView1);
            this.Name = "PacientList";
            this.Text = "PacientList";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Button info;
        private Button smazat;
    }
}