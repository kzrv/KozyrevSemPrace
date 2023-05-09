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
        public List<int> listSmazany;
        public bool change = false;
        private LekariSpravce sp;
        public PacientList(Lekar lekar,LekariSpravce sp)
        {
            this.sp = sp;
            InitializeComponent();
            this.lekar = lekar;
            reload();
            listSmazany = new List<int>();
        }

        private void smazat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int i = listView1.SelectedIndices[0];
                if (listSmazany.Contains(listView1.SelectedIndices[0]))
                {
                    listView1.Items[i].Font = new Font(listView1.Font, FontStyle.Regular);
                    listSmazany.Remove(i);
                }
                else
                {
                    listSmazany.Add(i);
                    listView1.Items[i].Font = new Font(listView1.Font, FontStyle.Strikeout);
                }

            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int i = listView1.SelectedIndices[0];
                InformaceP p = new(lekar.pacienty[i], sp, false);
                p.ShowDialog();
            }

        }
        private void reload()
        {
            foreach (Pacient p in lekar.pacienty)
            {
                listView1.Items.Add(p.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change = true;
            Close();
        }
    }
}
