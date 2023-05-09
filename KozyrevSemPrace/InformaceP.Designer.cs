namespace KozyrevSemPrace
{
    partial class InformaceP
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
            name = new Label();
            year = new Label();
            narozen = new TextBox();
            datumPrijety = new TextBox();
            label1 = new Label();
            rodneCislo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboOddeleni = new ComboBox();
            comboLekar = new ComboBox();
            label4 = new Label();
            diagnoza = new TextBox();
            stav = new TextBox();
            accept = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = SystemColors.ActiveCaption;
            name.Location = new Point(-5, -2);
            name.Name = "name";
            name.Size = new Size(587, 95);
            name.TabIndex = 0;
            name.Text = "Prijmeni Jmeno";
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Click += name_Click;
            // 
            // year
            // 
            year.Font = new Font("Segoe UI", 9.857143F, FontStyle.Italic, GraphicsUnit.Point);
            year.Location = new Point(12, 94);
            year.Name = "year";
            year.Size = new Size(257, 51);
            year.TabIndex = 1;
            year.Text = "Narozen:";
            year.Click += year_Click;
            // 
            // narozen
            // 
            narozen.Location = new Point(183, 94);
            narozen.Name = "narozen";
            narozen.Size = new Size(204, 35);
            narozen.TabIndex = 3;
            // 
            // datumPrijety
            // 
            datumPrijety.Location = new Point(183, 148);
            datumPrijety.Name = "datumPrijety";
            datumPrijety.ReadOnly = true;
            datumPrijety.Size = new Size(204, 35);
            datumPrijety.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(257, 51);
            label1.TabIndex = 4;
            label1.Text = "Datum prijety:";
            // 
            // rodneCislo
            // 
            rodneCislo.Location = new Point(183, 202);
            rodneCislo.Name = "rodneCislo";
            rodneCislo.Size = new Size(204, 35);
            rodneCislo.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 202);
            label2.Name = "label2";
            label2.Size = new Size(257, 51);
            label2.TabIndex = 6;
            label2.Text = "Rodne cislo:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(504, 9);
            label3.Name = "label3";
            label3.Size = new Size(587, 95);
            label3.TabIndex = 8;
            label3.Text = "Oddeleni:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // comboOddeleni
            // 
            comboOddeleni.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOddeleni.FormattingEnabled = true;
            comboOddeleni.Location = new Point(803, 41);
            comboOddeleni.Name = "comboOddeleni";
            comboOddeleni.Size = new Size(235, 38);
            comboOddeleni.TabIndex = 9;
            // 
            // comboLekar
            // 
            comboLekar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLekar.FormattingEnabled = true;
            comboLekar.Location = new Point(803, 126);
            comboLekar.Name = "comboLekar";
            comboLekar.Size = new Size(235, 38);
            comboLekar.TabIndex = 11;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(504, 94);
            label4.Name = "label4";
            label4.Size = new Size(587, 95);
            label4.TabIndex = 10;
            label4.Text = "Lekar:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // diagnoza
            // 
            diagnoza.Location = new Point(518, 188);
            diagnoza.Multiline = true;
            diagnoza.Name = "diagnoza";
            diagnoza.PlaceholderText = "Diagnoza";
            diagnoza.ScrollBars = ScrollBars.Vertical;
            diagnoza.Size = new Size(589, 438);
            diagnoza.TabIndex = 12;
            diagnoza.Tag = "";
            // 
            // stav
            // 
            stav.Location = new Point(12, 243);
            stav.Multiline = true;
            stav.Name = "stav";
            stav.PlaceholderText = "Stav pri prijety do nemocnici";
            stav.ScrollBars = ScrollBars.Vertical;
            stav.Size = new Size(476, 304);
            stav.TabIndex = 13;
            // 
            // accept
            // 
            accept.Location = new Point(12, 564);
            accept.Name = "accept";
            accept.Size = new Size(476, 62);
            accept.TabIndex = 14;
            accept.Text = "ULOZIT";
            accept.UseVisualStyleBackColor = true;
            accept.Click += accept_Click;
            // 
            // InformaceP
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 651);
            Controls.Add(accept);
            Controls.Add(stav);
            Controls.Add(diagnoza);
            Controls.Add(comboLekar);
            Controls.Add(label4);
            Controls.Add(comboOddeleni);
            Controls.Add(label3);
            Controls.Add(rodneCislo);
            Controls.Add(label2);
            Controls.Add(datumPrijety);
            Controls.Add(label1);
            Controls.Add(narozen);
            Controls.Add(year);
            Controls.Add(name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InformaceP";
            Text = "Informace o pacientu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label year;
        private TextBox narozen;
        private TextBox datumPrijety;
        private Label label1;
        private TextBox rodneCislo;
        private Label label2;
        private Label label3;
        private ComboBox comboOddeleni;
        private ComboBox comboLekar;
        private Label label4;
        private TextBox diagnoza;
        private TextBox stav;
        private Button accept;
    }
}