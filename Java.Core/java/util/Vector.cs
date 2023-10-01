using java.lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java.util
{
  
    public class Vector : ArrayList
    {

        public Vector(int p) : base(p)
        {
            //
        }

        public Vector()
        {
            // TODO: Complete member initialization
        }

        public void addElement(object item)
        {
            this.Add(item);
        }

        public void copyInto(object[] vec)
        {
            this.CopyTo(vec);
        }

        public int size()
        {
            return this.Count;
        }

        public object elementAt(int i)
        {
            return this[i];
        }

        public void removeElement(object o)
        {
            this.Remove(o);
        }

        public bool contains(object o)
        {
            return this.Contains(o);
        }

        public void removeAllElements()
        {
            this.Clear();
        }

        public void insertElementAt(object o, int count)
        {
            this.Insert(count, o);
        }
    }
}
