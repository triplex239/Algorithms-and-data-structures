using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_les1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Number(n);
        }
        static void Number (int n)
        {
            int d = 0, i = 2;
            while (i < n)
            {
                while (n % i == 0)
                {
                    d++;
                    i++;
                }
                i++;
            }
            if (d == 0) Console.WriteLine("простое");
            else Console.WriteLine("состовное");
            Console.ReadLine();
        }
    }
}
