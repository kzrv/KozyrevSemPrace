using ChampionsLeagueLibrary;
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
    public partial class AddPacient : Form
    {
        private LekariSpravce list;
        public Pacient pacient;
        public AddPacient(LekariSpravce list)
        {
            InitializeComponent();
            foreach (Oddeleni it in OddeleniInfo.GetArray)
            {
                oddeleniCombo.Items.Add(it);
            }
            oddeleniCombo.SelectedIndex = 0;
            comboLekar.Items.Add("None");
            comboLekar.SelectedItem = "None";
            for (int i = 0; i<list.Count; i++)
            {
                comboLekar.Items.Add(list[i].ToString());
            }
            this.list = list;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (checkRight())
            {
                Lekar? lekar = comboLekar.SelectedItem=="None"? null : (Lekar)list[comboLekar.SelectedIndex-1];
                Info info = new Info(diagnoza.Text,prijetiBox.Text,cisloBox.Text,(Oddeleni) oddeleniCombo.SelectedItem);
                this.pacient = new(jmenoBox.Text, PrijmeniBox.Text, narozeniBox.Text, lekar, info);
                Close();
            }
            
        }
        private bool checkRight()
        {
            if (jmenoBox.Text.Length > 0 && PrijmeniBox.Text.Length > 0 && cisloBox.Text.Length > 0)
            {
                Regex r1 = new Regex("^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\\d\\d$");
                if (!r1.IsMatch(prijetiBox.Text))
                {
                    MessageBox.Show("Spatny format datum prijety");
                    return false;
                }
                if(!r1.IsMatch(narozeniBox.Text))
                {
                    MessageBox.Show("Spatny format datum narozeni");
                    return false;
                }
                return true;
            }
            MessageBox.Show("Zadejte vsechny hodnoty");
            return false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
