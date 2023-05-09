namespace KozyrevSemPrace
{
    partial class NemocniceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pacientGrid = new DataGridView();
            nameP = new DataGridViewTextBoxColumn();
            prijmeni = new DataGridViewTextBoxColumn();
            vek = new DataGridViewTextBoxColumn();
            lekar = new DataGridViewTextBoxColumn();
            info = new DataGridViewButtonColumn();
            lekarGrid = new DataGridView();
            jmenoL = new DataGridViewTextBoxColumn();
            prijmeniL = new DataGridViewTextBoxColumn();
            cisloL = new DataGridViewTextBoxColumn();
            oddeleni = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewButtonColumn();
            addP = new Button();
            addL = new Button();
            ulozit = new Button();
            nacist = new Button();
            smazat = new Button();
            comboBox = new ComboBox();
            label1 = new Label();
            clear = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pacientGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lekarGrid).BeginInit();
            SuspendLayout();
            // 
            // pacientGrid
            // 
            pacientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pacientGrid.Columns.AddRange(new DataGridViewColumn[] { nameP, prijmeni, vek, lekar, info });
            pacientGrid.Location = new Point(12, 12);
            pacientGrid.Name = "pacientGrid";
            pacientGrid.RowHeadersWidth = 72;
            pacientGrid.RowTemplate.Height = 37;
            pacientGrid.Size = new Size(1186, 1000);
            pacientGrid.TabIndex = 0;
            // 
            // nameP
            // 
            nameP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameP.HeaderText = "Jmeno";
            nameP.MinimumWidth = 9;
            nameP.Name = "nameP";
            nameP.ReadOnly = true;
            // 
            // prijmeni
            // 
            prijmeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prijmeni.HeaderText = "Prijmeni";
            prijmeni.MinimumWidth = 9;
            prijmeni.Name = "prijmeni";
            prijmeni.ReadOnly = true;
            // 
            // vek
            // 
            vek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vek.HeaderText = "Datum narozeni";
            vek.MinimumWidth = 9;
            vek.Name = "vek";
            vek.ReadOnly = true;
            // 
            // lekar
            // 
            lekar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lekar.HeaderText = "Lekar";
            lekar.MinimumWidth = 9;
            lekar.Name = "lekar";
            lekar.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.HeaderText = "INFO";
            info.MinimumWidth = 9;
            info.Name = "info";
            info.ReadOnly = true;
            info.Resizable = DataGridViewTriState.True;
            info.SortMode = DataGridViewColumnSortMode.Automatic;
            info.Text = "INFO";
            info.UseColumnTextForButtonValue = true;
            // 
            // lekarGrid
            // 
            lekarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lekarGrid.Columns.AddRange(new DataGridViewColumn[] { jmenoL, prijmeniL, cisloL, oddeleni, dataGridViewComboBoxColumn1 });
            lekarGrid.Location = new Point(12, 12);
            lekarGrid.Name = "lekarGrid";
            lekarGrid.RowHeadersWidth = 72;
            lekarGrid.RowTemplate.Height = 37;
            lekarGrid.Size = new Size(1186, 1000);
            lekarGrid.TabIndex = 1;
            // 
            // jmenoL
            // 
            jmenoL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jmenoL.HeaderText = "Jmeno";
            jmenoL.MinimumWidth = 9;
            jmenoL.Name = "jmenoL";
            jmenoL.ReadOnly = true;
            jmenoL.Resizable = DataGridViewTriState.True;
            // 
            // prijmeniL
            // 
            prijmeniL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prijmeniL.HeaderText = "Prijmeni";
            prijmeniL.MinimumWidth = 9;
            prijmeniL.Name = "prijmeniL";
            prijmeniL.ReadOnly = true;
            // 
            // cisloL
            // 
            cisloL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cisloL.HeaderText = "Rodne Cislo";
            cisloL.MinimumWidth = 9;
            cisloL.Name = "cisloL";
            cisloL.ReadOnly = true;
            // 
            // oddeleni
            // 
            oddeleni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            oddeleni.HeaderText = "Oddeleni";
            oddeleni.MinimumWidth = 9;
            oddeleni.Name = "oddeleni";
            oddeleni.ReadOnly = true;
            oddeleni.Resizable = DataGridViewTriState.True;
            oddeleni.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewComboBoxColumn1.HeaderText = "Pacienty";
            dataGridViewComboBoxColumn1.MinimumWidth = 9;
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.ReadOnly = true;
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.Text = "PACIENTY";
            dataGridViewComboBoxColumn1.ToolTipText = "PACIENTY";
            dataGridViewComboBoxColumn1.UseColumnTextForButtonValue = true;
            // 
            // addP
            // 
            addP.Location = new Point(12, 1028);
            addP.Name = "addP";
            addP.Size = new Size(175, 63);
            addP.TabIndex = 2;
            addP.Text = "Novy pacient";
            addP.UseVisualStyleBackColor = true;
            addP.Click += addP_Click;
            // 
            // addL
            // 
            addL.Location = new Point(193, 1028);
            addL.Name = "addL";
            addL.Size = new Size(176, 63);
            addL.TabIndex = 3;
            addL.Text = "Novy lekar";
            addL.UseVisualStyleBackColor = true;
            addL.Click += addL_Click;
            // 
            // ulozit
            // 
            ulozit.Location = new Point(373, 1028);
            ulozit.Name = "ulozit";
            ulozit.Size = new Size(176, 63);
            ulozit.TabIndex = 4;
            ulozit.Text = "Ulozit";
            ulozit.UseVisualStyleBackColor = true;
            ulozit.Click += ulozit_Click;
            // 
            // nacist
            // 
            nacist.Location = new Point(554, 1028);
            nacist.Name = "nacist";
            nacist.Size = new Size(176, 63);
            nacist.TabIndex = 5;
            nacist.Text = "Nacist";
            nacist.UseVisualStyleBackColor = true;
            nacist.Click += nacist_Click;
            // 
            // smazat
            // 
            smazat.Location = new Point(735, 1028);
            smazat.Name = "smazat";
            smazat.Size = new Size(176, 63);
            smazat.TabIndex = 8;
            smazat.Text = "Smazat";
            smazat.UseVisualStyleBackColor = true;
            smazat.Click += button7_Click;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(12, 1105);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(228, 38);
            comboBox.TabIndex = 10;
            comboBox.SelectedIndexChanged += changeTypTabulky;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 1105);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 11;
            label1.Text = "TABULKA";
            // 
            // clear
            // 
            clear.Location = new Point(917, 1028);
            clear.Name = "clear";
            clear.Size = new Size(281, 63);
            clear.TabIndex = 12;
            clear.Text = "Smazat DATA";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(373, 1105);
            button1.Name = "button1";
            button1.Size = new Size(176, 40);
            button1.TabIndex = 13;
            button1.Text = "EDIT LEKAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NemocniceForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 1151);
            Controls.Add(button1);
            Controls.Add(clear);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(smazat);
            Controls.Add(nacist);
            Controls.Add(ulozit);
            Controls.Add(addL);
            Controls.Add(addP);
            Controls.Add(lekarGrid);
            Controls.Add(pacientGrid);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NemocniceForm";
            Text = "Nemocnice";
            ((System.ComponentModel.ISupportInitialize)pacientGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)lekarGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView pacientGrid;
        private DataGridView lekarGrid;
        private Button addP;
        private Button addL;
        private Button ulozit;
        private Button nacist;
        private Button smazat;
        private ComboBox comboBox;
        private Label label1;
        private Button clear;
        private DataGridViewTextBoxColumn nameP;
        private DataGridViewTextBoxColumn prijmeni;
        private DataGridViewTextBoxColumn vek;
        private DataGridViewTextBoxColumn lekar;
        private DataGridViewButtonColumn info;
        private DataGridViewTextBoxColumn jmenoL;
        private DataGridViewTextBoxColumn prijmeniL;
        private DataGridViewTextBoxColumn cisloL;
        private DataGridViewTextBoxColumn oddeleni;
        private DataGridViewButtonColumn dataGridViewComboBoxColumn1;
        private Button button1;
    }
}