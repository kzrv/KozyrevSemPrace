namespace KozyrevSemPrace
{
    partial class AddLekar
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
            this.label1 = new System.Windows.Forms.Label();
            this.jmenoBox = new System.Windows.Forms.TextBox();
            this.PrijmeniBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cisloBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oddeleniCombo = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jmeno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jmenoBox
            // 
            this.jmenoBox.Location = new System.Drawing.Point(174, 30);
            this.jmenoBox.Name = "jmenoBox";
            this.jmenoBox.Size = new System.Drawing.Size(204, 35);
            this.jmenoBox.TabIndex = 1;
            // 
            // PrijmeniBox
            // 
            this.PrijmeniBox.Location = new System.Drawing.Point(174, 94);
            this.PrijmeniBox.Name = "PrijmeniBox";
            this.PrijmeniBox.Size = new System.Drawing.Size(204, 35);
            this.PrijmeniBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijmeni";
            // 
            // cisloBox
            // 
            this.cisloBox.Location = new System.Drawing.Point(174, 166);
            this.cisloBox.Name = "cisloBox";
            this.cisloBox.Size = new System.Drawing.Size(204, 35);
            this.cisloBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rodne Cislo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oddeleni";
            // 
            // oddeleniCombo
            // 
            this.oddeleniCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oddeleniCombo.FormattingEnabled = true;
            this.oddeleniCombo.Location = new System.Drawing.Point(174, 238);
            this.oddeleniCombo.Name = "oddeleniCombo";
            this.oddeleniCombo.Size = new System.Drawing.Size(204, 38);
            this.oddeleniCombo.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(38, 322);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 40);
            this.add.TabIndex = 8;
            this.add.Text = "Pridat";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(247, 322);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 40);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Storno";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddLekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 417);
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
            this.Name = "AddLekar";
            this.Text = "AddLekar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox jmenoBox;
        private TextBox PrijmeniBox;
        private Label label2;
        private TextBox cisloBox;
        private Label label3;
        private Label label4;
        private ComboBox oddeleniCombo;
        private Button add;
        private Button cancel;
    }
}