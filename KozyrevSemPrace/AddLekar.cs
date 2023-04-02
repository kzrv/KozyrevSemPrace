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
        public AddLekar()
        {
            InitializeComponent();
            foreach (Oddeleni it in OddeleniInfo.GetArray)
            {
                oddeleniCombo.Items.Add(it);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if(jmenoBox.Text.Length > 0 && PrijmeniBox.Text.Length > 0 && cisloBox.Text.Length > 0 && oddeleniCombo.SelectedIndex!=null) {
            
                lekar = new Lekar(jmenoBox.Text,PrijmeniBox.Text,cisloBox.Text,(Oddeleni) oddeleniCombo.SelectedItem);
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
