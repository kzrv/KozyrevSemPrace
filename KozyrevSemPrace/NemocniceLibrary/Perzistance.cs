using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public static class Perzistance
    {
        public static void Save(string fileName, Pacient[] pacienty, Lekar[] lekari)
        {
            StreamWriter stream = new(fileName, false);
            foreach(Lekar l in lekari)
            {
                stream.WriteLine(l.toFile());
            }
            stream.WriteLine("##PACIENTY##");
            foreach(Pacient p in pacienty)
            {
                stream.WriteLine(p.toFile());
            }
            stream.Close();
        }
        public static void Load(string fileName, LekariSpravce lek, PacientSpravce pac)
        {
            List<Lekar> lekariList = new();
            StreamReader reader = new StreamReader(fileName);
            while (true)
            {
                string? line = reader.ReadLine();
                if(line == null || line== "##PACIENTY##") break;
                string[] obj = line.Split(';');
                try
                {
                    Lekar lekar = new Lekar(obj[0], obj[1], obj[2], (Oddeleni)Enum.Parse(typeof(Oddeleni), obj[3]));
                    lekariList.Add(lekar);
                }
                catch (ArgumentException e) { }
            }
            while (true)
            {
                string? line = reader.ReadLine();
                if (line == null) break;
                string[] obj = line.Split(";");
                try
                {
                    string jmeno = obj[0];
                    string prijmeni = obj[1];
                    string datumNarozeni = obj[2];
                    string lekar = obj[3];
                    Info info = new Info(obj[4], obj[5], obj[6], obj[7],(Oddeleni)Enum.Parse(typeof(Oddeleni),obj[8]));
                    Lekar? l1 = lekariList.Find(el => el.RodneCislo == lekar);
                    Pacient pacient = new Pacient(jmeno,prijmeni,datumNarozeni, l1,info);
                    if(l1!=null) l1.AddPacient(pacient);
                    pac.Add(pacient);
                } catch (ArgumentException e) { }   
            }
            reader.Close();
            foreach(Lekar l in lekariList)
            {
                lek.Add(l);
            }

        }
    }
}
