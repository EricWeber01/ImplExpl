using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplExpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Seconds s = new Seconds(100);
            Console.WriteLine(s);
            s = 228;
            Console.WriteLine(s);
            data d = new data(31, 3, 2022);
            data d2 = new data(20, 1, 2022);
            Console.WriteLine(d);
            Console.WriteLine((int)d);
            Console.WriteLine(++d);
            Console.WriteLine(--d);
            bool b = d > d2;
            b = d != d2;
        }
    }
}
