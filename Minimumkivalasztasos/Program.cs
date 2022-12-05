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
            Console.WriteLine("Minimumkiválasztásos rendezés");
            Stopwatch stopper = new Stopwatch();

            stopper.Start();
            for (int i = 0; i <= t.Length - 2; i++)
            {
                int min = i;
                for (int j = i + 1; j <= t.Length - 1; j++)
                {
                    if (t[min] > t[j])
                    {
                        min = j;
                    }
                }
                int temp = t[i];
                t[i] = t[min];
                t[min] = temp;
            }
            stopper.Stop();

            foreach (var e in t)
            {
                Console.Write($"{e} ");
            }
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
