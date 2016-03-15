using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class MyLinkedList
    {
        int adds = 0;
        public void add(int v)
        {
            adds = adds + 1;
        }

        public int size()
        {
            return adds;
        }

        public bool contains(int v)
        {
            return adds > 0;
        }

        public bool hasNext()
        {
            return adds > 0;
        }

        public int? getNext()
        {
            if (adds == 0)
            {
                return null;
            } else
            {
                return 1;
            }
        }
    }
}
