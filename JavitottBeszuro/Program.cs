using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BeszuroRendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] t = { 10, 2, 8, 3, 5, 6, 1, 7, 1 };
            int[] t = new int[80000];
            Beolvas(t);
            Console.WriteLine("Javított beszúró rendezés");
            Stopwatch stopper = new Stopwatch();

            stopper.Start();
            for (int i = 1; i <= t.Length - 1; i++)
            {
                int j = i - 1;
                int tmp = t[i];
                while ((j >= 0) && (t[j] > tmp))
                {
                    t[j + 1] = t[j];
                    j = j - 1;
                }
                t[j + 1] = tmp;
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
