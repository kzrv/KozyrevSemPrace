using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeagueLibrary
{
    public class ObjectLinkedList : ICollection, IEnumerable, IList
    {
        private Node? begin;
        private int count;
        public ObjectLinkedList()
        {
            count = 0;
        }
        public class Node
        {
            public Node? next;
            public Node? previous;
            public object? value;

            public Node(Node? previous, object? value, Node? next)
            {
                this.previous = previous;
                this.value = value;
                this.next = next;
            }
            
        }
        
        public object? this[int index]
        {
            get
            {
                if (begin == null || index>=count || index<0) return null;
                int i = 0;
                Node? el = begin;
                while(i<index)
                {
                    if (el == null) return null;
                    el = el.next;
                    i++;
                }
                return el.value;
            }
            set
            {
                Node node = begin;
                int i = 0;
                while(node != null)
                {
                    if (i == index)
                    {
                        node.value = value;
                    }
                    node = node.next;
                    i++;
                }
            }
        }

       
      

        public int Count => count;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        object? IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Add(object? value)
        {
            if (value == null) return -1;
            if(begin==null)
            {
                begin = new Node(null, value, null);
                return count++;
            }
            Node lastNode = begin;
            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            Node node = new Node(lastNode, value, null);
            lastNode.next = node;
            return count++;
        }

        public void Clear()
        {
            begin = null;
            count = 0;
        }

        public bool Contains(object? value)
        {
            if(begin==null || value==null) return false;
            Node? node = begin;
            while (node != null)
            {
                if (value == node.value) return true;
                node = node.next;
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            if (begin == null || array == null) return;
            Node node = begin;
            int i = index;
            while (node != null && i < array.Length)
            {
                array.SetValue(node.value, i++);
                node = node.next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            if (begin == null) return new EnumeratorClass();
            return new EnumeratorClass(count, begin);
        }

        public int IndexOf(object? value)
        {
            if(begin==null || value==null) return -1;
            Node? node = begin;
            int index = 0;
            while (node != null)
            {
                if (value == node.value) return index;
                node = node.next;
                index++;
            }
            return -1;
        }

        public void Insert(int index, object? value)
        {
            if(index<0 || value==null || index>count) return;
            if (count == 0 || index==0)
            {
                insertFirst(value, index);
                return;
            }
           
            int i = 0;
            Node? el = begin;
            while (i < index-1)
            {
                if (el == null) return;
                el = el.next;
                i++;
            }
            if (index == count)
            {
                Node node1 = new(el, value, null);
                el.next = node1;
                count++;
                return;
            }
            el = el.next;
            Node? node = new Node(el.previous, value, el);
            el.previous.next = node;
            el.previous = node;
            count++;

        }
        private void insertFirst(object? value,int index)
        {
            if (count == 0)
            {
                Add(value);
                return;
            }
            Node node1 = new Node(null, value, begin);
            begin.previous = node1;
            begin = node1;
            count++;
            return;

        }

        public void Remove(object? value)
        {
            if (value == null || begin==null) return;
            if (begin.value == value)
            {
                if (begin.next != null)
                {
                    begin = begin.next;
                    begin.previous = null;
                }
                else begin = null;
                count--;return;
            }
            Node el = begin.next;
            while(el!=null)
            {
                if(el.value == value)
                {
                    el.previous.next = el.next;
                    if(el.next!=null)el.next.previous = el.previous;
                    count--;
                    return;
                }
                el = el.next;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count || begin==null) return;
            Node node = begin;
            int i = 0;
            while(node!=null)
            {
                if (i == index)
                {
                    node.value = new string("for delete");
                    Remove(node.value); return;
                }
                node = node.next;
                i++;
               
            }
        }
        public class EnumeratorClass : IEnumerator
        {
            int pos = -1;
            Node? node;
            Node? first;
            int count;

            public EnumeratorClass(int count,Node? node)
            {
                this.count = count;
                this.node = node;
                first = node;
            }

            public EnumeratorClass()
            {
            }

            public object Current
            {
                get {
                    return node.value;
                }
            }
            

            public bool MoveNext()
            {
                pos++;
                if (pos > 0) node = node.next;
                return pos < count;
            }

            public void Reset()
            {
                pos = -1;
                node = first;
            }
        }
    }
}
