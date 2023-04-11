using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class Pacient
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string DatumNarozeni { get; set; } // format dd/MM/yyyy
        public Lekar? lekar { get; set; }

        public Info info { get; set; }

        public Pacient(string jmeno, string prijmeni, string datumNarozeni, Lekar lekar,Info info)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            this.info = info;
            this.lekar = lekar;
            if (lekar!=null && !lekar.pacienty.Contains(this))
            {
                lekar.pacienty.Add(this);
            }
        }

        public override string? ToString()
        {
            return $"{Jmeno} {Prijmeni} {info.RodneCislo}";
        }
    }
}
