using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class Lekar
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string RodneCislo { get; set; }  // make unique

        public Oddeleni oddeleni { get; set; }

        public List<Pacient> pacienty { get; }

        public Lekar(string jmeno, string prijmeni, string rodneCislo, Oddeleni oddeleni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RodneCislo = rodneCislo;
            this.oddeleni = oddeleni;
            pacienty = new List<Pacient>();
        }

        public void AddPacient(Pacient pacient)
        {
            if(!pacienty.Contains(pacient)) { 
                pacienty.Add(pacient);
            }
            if (pacient.lekar != this)
            {
                pacient.lekar = this;
            }
        }
        public void DeletePacient(Pacient pacient)
        {
            if (pacienty.Contains(pacient))
            {
                pacienty.Remove(pacient);
            }
        }

        public override string? ToString()
        {
            return Jmeno + " " + Prijmeni;
        }
        public string toFile()
        {
            return $"{Jmeno};{Prijmeni};{RodneCislo};{oddeleni}";
        }
    }
}
