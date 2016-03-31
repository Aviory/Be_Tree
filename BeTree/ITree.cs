using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeTree
{
    interface ITree
    {
        void clear();
        void add(int val);
        void init(int[] ar);
        int size();
        void print();
        int[] toArray();
        int nodes();  
        int leafs();
        void reverse();
        int height();
        int width();

        void del(int val); // !!!
    }
}
