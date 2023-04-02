namespace KozyrevSemPrace
{
    partial class AddPacient
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
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.oddeleniCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cisloBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrijmeniBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jmenoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.narozeniBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prijetiBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLekar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diagnoza = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(268, 649);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 40);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Storno";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(34, 649);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 40);
            this.add.TabIndex = 18;
            this.add.Text = "Pridat";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // oddeleniCombo
            // 
            this.oddeleniCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oddeleniCombo.FormattingEnabled = true;
            this.oddeleniCombo.Location = new System.Drawing.Point(195, 241);
            this.oddeleniCombo.Name = "oddeleniCombo";
            this.oddeleniCombo.Size = new System.Drawing.Size(204, 38);
            this.oddeleniCombo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Oddeleni";
            // 
            // cisloBox
            // 
            this.cisloBox.Location = new System.Drawing.Point(195, 169);
            this.cisloBox.Name = "cisloBox";
            this.cisloBox.Size = new System.Drawing.Size(204, 35);
            this.cisloBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rodne Cislo";
            // 
            // PrijmeniBox
            // 
            this.PrijmeniBox.Location = new System.Drawing.Point(195, 97);
            this.PrijmeniBox.Name = "PrijmeniBox";
            this.PrijmeniBox.Size = new System.Drawing.Size(204, 35);
            this.PrijmeniBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prijmeni";
            // 
            // jmenoBox
            // 
            this.jmenoBox.Location = new System.Drawing.Point(195, 33);
            this.jmenoBox.Name = "jmenoBox";
            this.jmenoBox.Size = new System.Drawing.Size(204, 35);
            this.jmenoBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jmeno";
            // 
            // narozeniBox
            // 
            this.narozeniBox.Location = new System.Drawing.Point(195, 310);
            this.narozeniBox.Name = "narozeniBox";
            this.narozeniBox.Size = new System.Drawing.Size(204, 35);
            this.narozeniBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datum narozeni";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // prijetiBox
            // 
            this.prijetiBox.Location = new System.Drawing.Point(195, 378);
            this.prijetiBox.Name = "prijetiBox";
            this.prijetiBox.Size = new System.Drawing.Size(204, 35);
            this.prijetiBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Datum Prijeti";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboLekar
            // 
            this.comboLekar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLekar.FormattingEnabled = true;
            this.comboLekar.Location = new System.Drawing.Point(195, 440);
            this.comboLekar.Name = "comboLekar";
            this.comboLekar.Size = new System.Drawing.Size(204, 38);
            this.comboLekar.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Lekar";
            // 
            // diagnoza
            // 
            this.diagnoza.Location = new System.Drawing.Point(34, 497);
            this.diagnoza.Multiline = true;
            this.diagnoza.Name = "diagnoza";
            this.diagnoza.PlaceholderText = "Diagnoza";
            this.diagnoza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diagnoza.Size = new System.Drawing.Size(365, 125);
            this.diagnoza.TabIndex = 26;
            // 
            // AddPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 791);
            this.Controls.Add(this.diagnoza);
            this.Controls.Add(this.comboLekar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prijetiBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.narozeniBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.oddeleniCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cisloBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrijmeniBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jmenoBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPacient";
            this.Text = "AddPacient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancel;
        private Button add;
        private ComboBox oddeleniCombo;
        private Label label4;
        private TextBox cisloBox;
        private Label label3;
        private TextBox PrijmeniBox;
        private Label label2;
        private TextBox jmenoBox;
        private Label label1;
        private TextBox narozeniBox;
        private Label label5;
        private TextBox prijetiBox;
        private Label label6;
        private ComboBox comboLekar;
        private Label label7;
        private TextBox diagnoza;
    }
}