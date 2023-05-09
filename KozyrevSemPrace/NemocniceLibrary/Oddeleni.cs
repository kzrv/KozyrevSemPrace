using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
     public enum Oddeleni
    {
        Chirurgicke = 0,
        Infekcni,
        Onkologie,
        ORL,
        Ocni,
        Psychiatrie
    }
    public static class OddeleniInfo
    {
        public static IEnumerable GetArray
        {
            get { return (Oddeleni[])Enum.GetValues(typeof(Oddeleni)); }
        }

        public static string GetName(Oddeleni oddeleni)
        {
            switch(oddeleni)
            {
                case Oddeleni.Chirurgicke: return "Chirurgické";
                case Oddeleni.Infekcni: return "Infekční";
                case Oddeleni.Onkologie: return "Onkologie";
                case Oddeleni.ORL: return "Otorhinolaryngologické";
                case Oddeleni.Ocni: return "Oční";
                case Oddeleni.Psychiatrie: return "Psychiatrické";
                default: return null;
            }
        }

    }
}
