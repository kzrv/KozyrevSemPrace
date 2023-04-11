using ChampionsLeagueLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class LekariSpravce
    {
        private ObjectLinkedList list;
        public int Count => list.Count;

        public Lekar this[int index] => (Lekar)list[index];



        public LekariSpravce()
        {
            this.list = new ObjectLinkedList();
        }

        public void Add(Lekar lekar)
        {
            list.Add(lekar);
        }
        public void Remove(Lekar lekar)
        {
            list.Remove(lekar);
        }
        public void AddPacient(Lekar lekar,Pacient pacient)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]==lekar)
                {
                    lekar.AddPacient(pacient);
                    list[i] = lekar;
                }
            }
        }
    }
}
