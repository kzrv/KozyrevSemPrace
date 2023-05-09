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
            cancel = new Button();
            add = new Button();
            oddeleniCombo = new ComboBox();
            label4 = new Label();
            cisloBox = new TextBox();
            label3 = new Label();
            PrijmeniBox = new TextBox();
            label2 = new Label();
            jmenoBox = new TextBox();
            label1 = new Label();
            narozeniBox = new TextBox();
            label5 = new Label();
            comboLekar = new ComboBox();
            label7 = new Label();
            diagnoza = new TextBox();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.Location = new Point(268, 572);
            cancel.Name = "cancel";
            cancel.Size = new Size(131, 40);
            cancel.TabIndex = 19;
            cancel.Text = "Storno";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // add
            // 
            add.Location = new Point(34, 572);
            add.Name = "add";
            add.Size = new Size(131, 40);
            add.TabIndex = 18;
            add.Text = "Pridat";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // oddeleniCombo
            // 
            oddeleniCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            oddeleniCombo.FormattingEnabled = true;
            oddeleniCombo.Location = new Point(195, 222);
            oddeleniCombo.Name = "oddeleniCombo";
            oddeleniCombo.Size = new Size(204, 38);
            oddeleniCombo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 222);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 16;
            label4.Text = "Oddeleni";
            // 
            // cisloBox
            // 
            cisloBox.Location = new Point(195, 159);
            cisloBox.Name = "cisloBox";
            cisloBox.Size = new Size(204, 35);
            cisloBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 164);
            label3.Name = "label3";
            label3.Size = new Size(122, 30);
            label3.TabIndex = 14;
            label3.Text = "Rodne Cislo";
            // 
            // PrijmeniBox
            // 
            PrijmeniBox.Location = new Point(195, 96);
            PrijmeniBox.Name = "PrijmeniBox";
            PrijmeniBox.Size = new Size(204, 35);
            PrijmeniBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 101);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 12;
            label2.Text = "Prijmeni";
            // 
            // jmenoBox
            // 
            jmenoBox.Location = new Point(195, 33);
            jmenoBox.Name = "jmenoBox";
            jmenoBox.Size = new Size(204, 35);
            jmenoBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 10;
            label1.Text = "Jmeno";
            // 
            // narozeniBox
            // 
            narozeniBox.Location = new Point(195, 286);
            narozeniBox.Name = "narozeniBox";
            narozeniBox.PlaceholderText = "dd/MM/yyyy";
            narozeniBox.Size = new Size(204, 35);
            narozeniBox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 291);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 20;
            label5.Text = "Datum narozeni";
            label5.Click += label5_Click;
            // 
            // comboLekar
            // 
            comboLekar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLekar.FormattingEnabled = true;
            comboLekar.Location = new Point(195, 348);
            comboLekar.Name = "comboLekar";
            comboLekar.Size = new Size(204, 38);
            comboLekar.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 348);
            label7.Name = "label7";
            label7.Size = new Size(62, 30);
            label7.TabIndex = 24;
            label7.Text = "Lekar";
            // 
            // diagnoza
            // 
            diagnoza.Location = new Point(34, 420);
            diagnoza.Multiline = true;
            diagnoza.Name = "diagnoza";
            diagnoza.PlaceholderText = "Stav při přijetí";
            diagnoza.ScrollBars = ScrollBars.Vertical;
            diagnoza.Size = new Size(365, 125);
            diagnoza.TabIndex = 26;
            // 
            // AddPacient
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 644);
            Controls.Add(diagnoza);
            Controls.Add(comboLekar);
            Controls.Add(label7);
            Controls.Add(narozeniBox);
            Controls.Add(label5);
            Controls.Add(cancel);
            Controls.Add(add);
            Controls.Add(oddeleniCombo);
            Controls.Add(label4);
            Controls.Add(cisloBox);
            Controls.Add(label3);
            Controls.Add(PrijmeniBox);
            Controls.Add(label2);
            Controls.Add(jmenoBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPacient";
            Text = "AddPacient";
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox comboLekar;
        private Label label7;
        private TextBox diagnoza;
    }
}