using KozyrevSemPrace.NemocniceLibrary;
using System.Windows.Forms;

namespace KozyrevSemPrace
{
    public partial class NemocniceForm : Form
    {
        private string lekari = "LEKARI";
        private string pacienty = "PACIENTY";
        private LekariSpravce spravceL;
        private PacientSpravce spravceP;
        private bool aktual; //true - pacienty; false - lekari
        public NemocniceForm()
        {
            InitializeComponent();
            comboBox.Items.Add(lekari);
            comboBox.Items.Add(pacienty);
            comboBox.SelectedItem = pacienty;
            spravceL = new LekariSpravce();
            spravceP = new PacientSpravce();
            lekarGrid.AllowUserToAddRows = false;
            pacientGrid.AllowUserToAddRows = false;
            lekarGrid.CellContentClick += new DataGridViewCellEventHandler(pacientyList_Change);
            pacientGrid.CellContentClick += new DataGridViewCellEventHandler(pacientyInfo);
            reload();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (aktual)
            {
                if (pacientGrid.SelectedRows.Count > 0)
                {
                    int i = pacientGrid.CurrentCell.RowIndex;
                    Pacient value = (spravceP[i]);
                    spravceP.Remove(value);
                    if (value.lekar != null)
                    {
                        spravceL.RemovePacient(value);
                    }
                }

            }
            else
            {
                if (lekarGrid.SelectedRows.Count > 0)
                {
                    int i = pacientGrid.CurrentCell.RowIndex;
                    Lekar value = spravceL[i];
                    spravceL.Remove(value);
                    foreach (Pacient p in value.pacienty)
                    {
                        spravceP.RemoveLekar(p);
                    }
                }
            }
            reload();
        }

        private void changeTypTabulky(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                pacientGrid.Visible = false;
                lekarGrid.Visible = true;
                aktual = false;
            }
            else
            {
                pacientGrid.Visible = true;
                lekarGrid.Visible = false;
                aktual = true;
            }
        }

        private void addL_Click(object sender, EventArgs e)
        {
            AddLekar addLekar = new AddLekar();
            addLekar.ShowDialog();
            if (addLekar.lekar != null)
            {
                spravceL.Add(addLekar.lekar);
                reload();
            }
        }
        private void reload()
        {
            lekarGrid.Rows.Clear();
            pacientGrid.Rows.Clear();
            for (int it = 0; it < spravceL.Count; it++)
            {
                if (spravceL[it] != null)
                {
                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    buttonCell.Value = "PACIENTY";

                    lekarGrid.Rows.Add(spravceL[it].Jmeno, spravceL[it].Prijmeni, spravceL[it].RodneCislo, OddeleniInfo.GetName(spravceL[it].oddeleni), buttonCell);
                }
            }

            for (int it = 0; it < spravceP.Count; it++)
            {
                if (spravceP[it] != null)
                {
                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    buttonCell.Value = "INFO";
                    pacientGrid.Rows.Add(spravceP[it].Jmeno, spravceP[it].Prijmeni, spravceP[it].DatumNarozeni, spravceP[it].lekar, buttonCell);

                }
            }
        }

        private void addP_Click(object sender, EventArgs e)
        {
            AddPacient addPacient = new AddPacient(spravceL);
            addPacient.ShowDialog();
            if (addPacient.pacient != null)
            {
                spravceP.Add(addPacient.pacient);
                if (addPacient.pacient.lekar != null) spravceL.AddPacient(addPacient.pacient.lekar, addPacient.pacient);
                reload();
            }
        }
        private void informaceClick(object sender, EventArgs e)
        {

        }

        private void ulozit_Click(object sender, EventArgs e)
        {
            SaveFileDialog dia = new SaveFileDialog();
            dia.Filter = "Text soubor(*.nemocnice)|*.nemocnice";
            DialogResult res = dia.ShowDialog();
            if (res == DialogResult.OK)
            {
                Perzistance.Save(dia.FileName, spravceP.toList(), spravceL.toList());
            }
        }

        private void nacist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pokud nahrajete nová data, všechna předchozí budou smazána.", "Podtverdite", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OpenFileDialog dia = new OpenFileDialog();
                dia.Filter = "Text soubor(*.nemocnice)|*.nemocnice";
                DialogResult res = dia.ShowDialog();
                if (res == DialogResult.OK)
                {
                    spravceL.Clear();
                    spravceP.Clear();
                    Perzistance.Load(dia.FileName, spravceL, spravceP);
                    reload();
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            spravceL.Clear();
            spravceP.Clear();
            reload();
        }

        private void pacientyList_Change(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == lekarGrid.Columns["dataGridViewComboBoxColumn1"].Index && e.RowIndex >= 0)
            {
                PacientList list = new PacientList(spravceL[e.RowIndex],spravceL);
                list.ShowDialog();
                if (list.change && list.listSmazany.Count > 0)
                {
                    foreach (int i in list.listSmazany)
                    {
                        Lekar value = spravceL[e.RowIndex];
                        Pacient p = spravceL.RemovePacient(value, i);
                        if (p != null) spravceP.RemoveLekar(p);
                    }
                }
                reload();
            }
        
        }
        private void pacientyInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == pacientGrid.Columns["info"].Index && e.RowIndex >= 0)
            {
                InformaceP p = new(spravceP[e.RowIndex], spravceL, true) ;
                p.ShowDialog();
                if (p.change)
                {
                    spravceP.Insert(e.RowIndex, p.pacient);
                    reload();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lekarGrid.SelectedCells.Count > 0)
            {
                int i = pacientGrid.CurrentCell.RowIndex;
                AddLekar l = new(spravceL[i]);
                l.ShowDialog();
                if (l.change)
                {
                    spravceL.changeLekar(l.lekar, i);
                    if (l.lekar.pacienty.Count > 0)
                    {
                        foreach (Pacient p in l.lekar.pacienty)
                        {
                            spravceP.changeLekar(p, l.lekar);
                        }
                    }
                }
                reload();
            }
        }
    }
}