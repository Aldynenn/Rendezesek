using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Buborek
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] t = { 10, 2, 8, 3, 5, 6, 1, 7, 1 };
            int[] t = new int[80000];
            Beolvas(t);
            Console.WriteLine("Javított buborék rendezés");
            Stopwatch stopper = new Stopwatch();

            stopper.Start();
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
            stopper.Stop();

            //foreach (var e in t)
            //{
            //    Console.Write($"{e} ");
            //}
            Console.WriteLine($"Eltelt {stopper.ElapsedMilliseconds}");

            Console.ReadKey();
        }

        private static void Beolvas(int[] t)
        {
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                int j = 0;
                while (!sr.EndOfStream)
                {
                    t[j++] = Convert.ToInt32(sr.ReadLine());
                }
            }
        }
    }
}
