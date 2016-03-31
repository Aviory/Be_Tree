using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BStree pp = new BStree();
            int[] ar = { 50, 20, 70, 11, 24, 33, 99, 18 };
            pp.init(ar);
            Console.WriteLine(pp.width());
            Console.ReadKey();
        }
    }
}
