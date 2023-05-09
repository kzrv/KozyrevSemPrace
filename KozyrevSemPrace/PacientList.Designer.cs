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
            listView1 = new ListView();
            info = new Button();
            smazat = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(12, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(472, 573);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // info
            // 
            info.Location = new Point(12, 608);
            info.Name = "info";
            info.Size = new Size(233, 40);
            info.TabIndex = 1;
            info.Text = "INFORMACE";
            info.UseVisualStyleBackColor = true;
            info.Click += info_Click;
            // 
            // smazat
            // 
            smazat.Location = new Point(251, 608);
            smazat.Name = "smazat";
            smazat.Size = new Size(233, 40);
            smazat.TabIndex = 2;
            smazat.Text = "SMAZAT/VRATIT";
            smazat.UseVisualStyleBackColor = true;
            smazat.Click += smazat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 662);
            button1.Name = "button1";
            button1.Size = new Size(471, 40);
            button1.TabIndex = 3;
            button1.Text = "ACCEPT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PacientList
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 707);
            Controls.Add(button1);
            Controls.Add(smazat);
            Controls.Add(info);
            Controls.Add(listView1);
            MaximizeBox = false;
            Name = "PacientList";
            Text = "PacientList";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button info;
        private Button smazat;
        private Button button1;
    }
}