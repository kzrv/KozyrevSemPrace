using KozyrevSemPrace.NemocniceLibrary;

namespace KozyrevSemPrace
{
    public partial class NemocniceForm : Form
    {
        private string lekari = "LEKARI";
        private string pacienty = "PACIENTY";
        private LekariSpravce spravceL;
        private PacientSpravce spravceP;
        public NemocniceForm()
        {
            InitializeComponent();
            comboBox.Items.Add(lekari) ;
            comboBox.Items.Add(pacienty);
            comboBox.SelectedItem = pacienty;
            spravceL= new LekariSpravce();
            spravceP = new PacientSpravce();
            lekarGrid.AllowUserToAddRows = false;
            pacientGrid.AllowUserToAddRows = false;
            reload();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void changeTypTabulky(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex==0) {
                pacientGrid.Visible = false;
                lekarGrid.Visible = true;
            }
            else
            {
                pacientGrid.Visible = true;
                lekarGrid.Visible = false;
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
                if (it != null)
                {
         
                    lekarGrid.Rows.Add(spravceL[it].Jmeno, spravceL[it].Prijmeni, spravceL[it].RodneCislo, OddeleniInfo.GetName(spravceL[it].oddeleni), new Button());

                }
            }
            
            for(int it = 0; it < spravceP.Count; it++)
            {
                if (it != null)
                {
                    Button btn = new Button();
                    btn.Name = "Informace";
                    btn.Text = "Informace o pacientu";
                    btn.Click += informaceClick;
                    pacientGrid.Rows.Add(spravceP[it].Jmeno, spravceP[it].Prijmeni, spravceP[it].DatumNarozeni, spravceP[it].lekar, btn);

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
                if(addPacient.pacient.lekar!=null) spravceL.AddPacient(addPacient.pacient.lekar, addPacient.pacient);
                reload();
            }
        }
        private void informaceClick(object sender, EventArgs e)
        {

        }
    }
}