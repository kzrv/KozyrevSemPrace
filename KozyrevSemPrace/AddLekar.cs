using KozyrevSemPrace.NemocniceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KozyrevSemPrace
{
    public partial class AddLekar : Form
    {
        public Lekar lekar;
        public bool change;
        public AddLekar()
        {
            InitializeComponent();
            foreach (Oddeleni it in OddeleniInfo.GetArray)
            {
                oddeleniCombo.Items.Add(it);
                change = true;
            }
        }
        public AddLekar(Lekar lekar)
        {
            this.lekar = lekar;
            InitializeComponent();
            foreach (Oddeleni it in OddeleniInfo.GetArray)
            {
                oddeleniCombo.Items.Add(it);
            }
            jmenoBox.Text = lekar.Jmeno;
            PrijmeniBox.Text = lekar.Prijmeni;
            cisloBox.Text = lekar.RodneCislo;
            oddeleniCombo.SelectedIndex = (int)Enum.Parse(typeof(Oddeleni), lekar.oddeleni.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if(jmenoBox.Text.Length > 0 && PrijmeniBox.Text.Length > 0 && cisloBox.Text.Length > 0 && oddeleniCombo.SelectedIndex!=null) {
                List<Pacient> l = lekar.pacienty;
                lekar = new Lekar(jmenoBox.Text,PrijmeniBox.Text,cisloBox.Text,(Oddeleni) oddeleniCombo.SelectedItem);
                foreach(Pacient p in l)
                {
                    lekar.AddPacient(p);
                }
                change = true;
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
