using ChampionsLeagueLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public int GetLekar(Lekar l)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((Lekar)list[i] == l)
                {
                    return i;
                }
            }
            return -1;
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
                if ((Lekar)list[i]==lekar)
                {
                    lekar.AddPacient(pacient);
                    list[i] = lekar;
                }
            }
        }

        public Lekar[] toList()
        {
            Lekar[] l = new Lekar[Count];
            list.CopyTo(l, 0);
            return l;
        }
        public void Clear()
        {
            list.Clear();
        }
        public void RemovePacient(Pacient pacient)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((Lekar)list[i] == pacient.lekar)
                {
                    Lekar l = pacient.lekar;
                    l.DeletePacient(pacient);
                    list[i] = l;
                    break;
                }
            }
        }
        public Pacient RemovePacient(Lekar lekar,int index)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((Lekar)list[i] == lekar)
                {
                    Pacient p = ((Lekar)list[i]).pacienty[index];
                    ((Lekar)list[i]).pacienty.RemoveAt(index);
                    return p;
                    
                }
            }
            return null;
        }
        public void changeLekar(Lekar lekar,int index)
        {
            list[index] = lekar;
        }

    }
}
