using ChampionsLeagueLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class PacientSpravce
    {
        private ObjectLinkedList list;
        public int Count => list.Count;

        public Pacient this[int index] => (Pacient)list[index];



        public PacientSpravce()
        {
            this.list = new ObjectLinkedList();
        }

        public void Add(Pacient lekar)
        {
            list.Add(lekar);
        }
        public void Remove(Pacient lekar)
        {
            list.Remove(lekar);
        }
    }
}
