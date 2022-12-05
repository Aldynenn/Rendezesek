using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 10, 2, 8, 3, 5, 6, 1, 7, 1 };
            Console.WriteLine("Buborék rendezés");

            for (int i = t.Length - 1; i >= 1; i--)
            {
                for (int ii = 0; ii <= i - 1; ii++)
                {
                    if (t[ii] > t[ii + 1])
                    {
                        int temp = t[ii];
                        t[ii] = t[ii + 1];
                        t[ii + 1] = temp;
                    }
                }
            }

            foreach (var e in t)
            {
                Console.Write($"{e} ");
            }

            Console.ReadKey();
        }
    }
}
