using KozyrevSemPrace.NemocniceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KozyrevSemPrace
{
    public partial class InformaceP : Form
    {
        public Pacient pacient;
        private LekariSpravce l;
        public bool change = false;
        private bool editable;
        public InformaceP(Pacient pacient, LekariSpravce l,bool editable)
        {
            this.editable = editable;
            this.pacient = pacient;
            this.l = l;
            InitializeComponent();

            name.Text = pacient.Prijmeni + " " + pacient.Jmeno;
            narozen.Text = pacient.DatumNarozeni;
            datumPrijety.Text = pacient.info.DatumPrijety;
            rodneCislo.Text = pacient.info.RodneCislo;
            foreach (Oddeleni it in OddeleniInfo.GetArray)
            {
                comboOddeleni.Items.Add(it);
            }
            comboOddeleni.SelectedIndex = (int)Enum.Parse(typeof(Oddeleni), pacient.info.oddeleni.ToString());
            for (int i = 0; i < l.Count; i++)
            {
                comboLekar.Items.Add(l[i].ToString());
            }
            if (pacient.lekar != null) comboLekar.SelectedIndex = l.GetLekar(pacient.lekar);
            stav.Text = pacient.info.StavPrijety;
            diagnoza.Text = pacient.info.Diagnoza;
            if (!editable)
            {
                narozen.ReadOnly = true;
                datumPrijety.ReadOnly = true;
                rodneCislo.ReadOnly = true;
                comboOddeleni.Enabled = false;
                comboLekar.Enabled = false;
                stav.ReadOnly = true;
                diagnoza.ReadOnly = true;
            }
        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            if(editable)
            {
                ChangeName n = new ChangeName(pacient.Jmeno, pacient.Prijmeni);
                n.ShowDialog();
                if (n.change)
                {
                    name.Text = n.jmeno + " " + n.prijmeni;
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                Regex r1 = new Regex("^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\\d\\d$");
                if (r1.IsMatch(narozen.Text) && rodneCislo.Text != "")
                {
                    l.RemovePacient(pacient);
                    string[] n = name.Text.Split(" ");
                    pacient.Jmeno = n[0];
                    pacient.Prijmeni = n[1];
                    pacient.DatumNarozeni = narozen.Text;
                    pacient.info.RodneCislo = rodneCislo.Text;
                    pacient.info.StavPrijety = stav.Text;
                    pacient.info.Diagnoza = diagnoza.Text;
                    if (comboLekar.SelectedIndex >= 0)
                    {
                        pacient.lekar = l[comboLekar.SelectedIndex];
                    }
                    if (pacient.lekar != null)
                    {
                        l.AddPacient(pacient.lekar, pacient);
                    }
                    change = true;
                    Close();
                }
            }
            else Close();
        }
    }
}
