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
            this.pacientGrid = new System.Windows.Forms.DataGridView();
            this.lekarGrid = new System.Windows.Forms.DataGridView();
            this.jmenoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisloL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oddeleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addP = new System.Windows.Forms.Button();
            this.addL = new System.Windows.Forms.Button();
            this.ulozit = new System.Windows.Forms.Button();
            this.nacist = new System.Windows.Forms.Button();
            this.smazat = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pacientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientGrid
            // 
            this.pacientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameP,
            this.prijmeni,
            this.vek,
            this.lekar,
            this.info});
            this.pacientGrid.Location = new System.Drawing.Point(12, 21);
            this.pacientGrid.Name = "pacientGrid";
            this.pacientGrid.RowHeadersWidth = 72;
            this.pacientGrid.RowTemplate.Height = 37;
            this.pacientGrid.Size = new System.Drawing.Size(1186, 1000);
            this.pacientGrid.TabIndex = 0;
            // 
            // lekarGrid
            // 
            this.lekarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lekarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jmenoL,
            this.prijmeniL,
            this.cisloL,
            this.oddeleni,
            this.dataGridViewComboBoxColumn1});
            this.lekarGrid.Location = new System.Drawing.Point(12, 21);
            this.lekarGrid.Name = "lekarGrid";
            this.lekarGrid.RowHeadersWidth = 72;
            this.lekarGrid.RowTemplate.Height = 37;
            this.lekarGrid.Size = new System.Drawing.Size(1186, 1000);
            this.lekarGrid.TabIndex = 1;
            // 
            // jmenoL
            // 
            this.jmenoL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jmenoL.HeaderText = "Jmeno";
            this.jmenoL.MinimumWidth = 9;
            this.jmenoL.Name = "jmenoL";
            // 
            // prijmeniL
            // 
            this.prijmeniL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prijmeniL.HeaderText = "Prijmeni";
            this.prijmeniL.MinimumWidth = 9;
            this.prijmeniL.Name = "prijmeniL";
            // 
            // cisloL
            // 
            this.cisloL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cisloL.HeaderText = "Rodne Cislo";
            this.cisloL.MinimumWidth = 9;
            this.cisloL.Name = "cisloL";
            // 
            // oddeleni
            // 
            this.oddeleni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oddeleni.HeaderText = "Oddeleni";
            this.oddeleni.MinimumWidth = 9;
            this.oddeleni.Name = "oddeleni";
            this.oddeleni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oddeleni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.HeaderText = "Pacienty";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 9;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addP
            // 
            this.addP.Location = new System.Drawing.Point(12, 1072);
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(176, 63);
            this.addP.TabIndex = 2;
            this.addP.Text = "Novy pacient";
            this.addP.UseVisualStyleBackColor = true;
            this.addP.Click += new System.EventHandler(this.addP_Click);
            // 
            // addL
            // 
            this.addL.Location = new System.Drawing.Point(194, 1072);
            this.addL.Name = "addL";
            this.addL.Size = new System.Drawing.Size(176, 63);
            this.addL.TabIndex = 3;
            this.addL.Text = "Novy lekar";
            this.addL.UseVisualStyleBackColor = true;
            this.addL.Click += new System.EventHandler(this.addL_Click);
            // 
            // ulozit
            // 
            this.ulozit.Location = new System.Drawing.Point(374, 1072);
            this.ulozit.Name = "ulozit";
            this.ulozit.Size = new System.Drawing.Size(176, 63);
            this.ulozit.TabIndex = 4;
            this.ulozit.Text = "Ulozit";
            this.ulozit.UseVisualStyleBackColor = true;
            // 
            // nacist
            // 
            this.nacist.Location = new System.Drawing.Point(555, 1072);
            this.nacist.Name = "nacist";
            this.nacist.Size = new System.Drawing.Size(176, 63);
            this.nacist.TabIndex = 5;
            this.nacist.Text = "Nacist";
            this.nacist.UseVisualStyleBackColor = true;
            // 
            // smazat
            // 
            this.smazat.Location = new System.Drawing.Point(736, 1072);
            this.smazat.Name = "smazat";
            this.smazat.Size = new System.Drawing.Size(176, 63);
            this.smazat.TabIndex = 8;
            this.smazat.Text = "Smazat";
            this.smazat.UseVisualStyleBackColor = true;
            this.smazat.Click += new System.EventHandler(this.button7_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(916, 1072);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(176, 63);
            this.edit.TabIndex = 9;
            this.edit.Text = "Editovat";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(1204, 21);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(228, 38);
            this.comboBox.TabIndex = 10;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.changeTypTabulky);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1438, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "TABULKA";
            // 
            // nameP
            // 
            this.nameP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameP.HeaderText = "Jmeno";
            this.nameP.MinimumWidth = 9;
            this.nameP.Name = "nameP";
            // 
            // prijmeni
            // 
            this.prijmeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prijmeni.HeaderText = "Prijmeni";
            this.prijmeni.MinimumWidth = 9;
            this.prijmeni.Name = "prijmeni";
            // 
            // vek
            // 
            this.vek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vek.HeaderText = "Datum narozeni";
            this.vek.MinimumWidth = 9;
            this.vek.Name = "vek";
            // 
            // lekar
            // 
            this.lekar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lekar.HeaderText = "Lekar";
            this.lekar.MinimumWidth = 9;
            this.lekar.Name = "lekar";
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.HeaderText = "INFO";
            this.info.MinimumWidth = 9;
            this.info.Name = "info";
            this.info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.info.Text = "INFO";
            this.info.UseColumnTextForButtonValue = true;
            // 
            // NemocniceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.smazat);
            this.Controls.Add(this.nacist);
            this.Controls.Add(this.ulozit);
            this.Controls.Add(this.addL);
            this.Controls.Add(this.addP);
            this.Controls.Add(this.lekarGrid);
            this.Controls.Add(this.pacientGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NemocniceForm";
            this.Text = "Nemocnice";
            ((System.ComponentModel.ISupportInitialize)(this.pacientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView pacientGrid;
        private DataGridView lekarGrid;
        private Button addP;
        private Button addL;
        private Button ulozit;
        private Button nacist;
        private Button smazat;
        private Button edit;
        private ComboBox comboBox;
        private Label label1;
        private DataGridViewTextBoxColumn jmenoL;
        private DataGridViewTextBoxColumn prijmeniL;
        private DataGridViewTextBoxColumn cisloL;
        private DataGridViewTextBoxColumn oddeleni;
        private DataGridViewButtonColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn nameP;
        private DataGridViewTextBoxColumn prijmeni;
        private DataGridViewTextBoxColumn vek;
        private DataGridViewTextBoxColumn lekar;
        private DataGridViewButtonColumn info;
    }
}