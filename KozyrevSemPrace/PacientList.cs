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
    public partial class PacientList : Form
    {
        private Lekar lekar;
        public List<Pacient> listSmazany;
        public PacientList(Lekar lekar)
        {
            InitializeComponent();
            this.lekar = lekar;
            reload();
        }

        private void smazat_Click(object sender, EventArgs e)
        {
           // lekar.pacienty.Remove(listView1.)
        }

        private void info_Click(object sender, EventArgs e)
        {

        }
        private void reload()
        {
            foreach(Pacient p in lekar.pacienty)
            {
                listView1.Items.Add(p.ToString());
            }
        }
    }
}
