using ChampionsLeagueLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KozyrevSemPrace.NemocniceLibrary
{
    public class PacientSpravce
    {
        private ObjectLinkedList list;
        public int Count => list.Count;

        public Pacient this[int index] => (Pacient)list[index];

        public void Insert(int index, Pacient pacient)
        {
            list[index] = pacient;
        }



        public PacientSpravce()
        {
            this.list = new ObjectLinkedList();
        }

        public void Add(Pacient pacient)
        {
            list.Add(pacient);
        }
        public void Remove(Pacient pacient)
        {
            list.Remove(pacient);
        }
        public void Remove(int i)
        {
            list.RemoveAt(i);
        }


        public Pacient[] toList()
        {
            Pacient[] l = new Pacient[Count];
            list.CopyTo(l, 0);
            return l;
        }
        public void Clear()
        {
            list.Clear();
        }
        public void RemoveLekar(Pacient pacient)
        {
            for(int i = 0; i < Count; i++)
            {
                if ((Pacient)list[i] == pacient)
                {
                    ((Pacient)list[i]).lekar = null;
                    break;
                }
            }
        }
        public void changeLekar(Pacient p, Lekar l)
        {
            for(int i = 0; i < Count; i++)
            {
                if (list[i] == p)
                {
                    ((Pacient)list[i]).lekar = l; break;
                }
            }
        }
       
       
    }
}
