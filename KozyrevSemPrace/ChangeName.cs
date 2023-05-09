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
    public partial class ChangeName : Form
    {
        public string jmeno, prijmeni;
        public bool change = false;
        public ChangeName(string name, string prijmeni)
        {
            InitializeComponent();
            this.jmeno = name;
            this.prijmeni = prijmeni;
            textBox.Text = name;
            textBox1.Text = this.prijmeni;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                jmeno = textBox.Text;
                prijmeni = textBox1.Text;
            change = true;
            Close();
            }
            else
            {
                MessageBox.Show("ZADEJTE JMENO A PRIJMENI");
            }
            
        }
    }
}
