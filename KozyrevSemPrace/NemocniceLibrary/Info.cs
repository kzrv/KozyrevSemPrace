using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class Info
    {
        public string StavPrijety { get; set; } 
        public string Diagnoza { get; set; }
        public string DatumPrijety { get; set; }

        public string RodneCislo { get; set; }
        public Oddeleni oddeleni { get; set; }

        public Info(string stavPrijety, string diagnoza, string datumPrijety, string rodneCislo, Oddeleni oddeleni)
        {
            StavPrijety = stavPrijety;
            Diagnoza = diagnoza;
            DatumPrijety = datumPrijety;
            RodneCislo = rodneCislo;
            this.oddeleni = oddeleni;
        }

        public string toFile()
        {
            return $"{StavPrijety};{Diagnoza};{DatumPrijety};{RodneCislo};{oddeleni}";
        }
    }
}
