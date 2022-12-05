using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EgyszeruCsere
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] t = { 10, 2, 8, 3, 5, 6, 1, 7, 1 };
            int[] t = new int[80000];
            Stopwatch stopper = new Stopwatch();
            Beolvas(t);

            Console.WriteLine("Egyszerű cserés rendezés");

            stopper.Start();
            for (int i = 0; i < t.Length - 1; i++)
            {
                for (int ii = i + 1; ii < t.Length; ii++)
                {
                    if (t[ii] < t[i])
                    {
                        int temp = t[i];
                        t[i] = t[ii];
                        t[ii] = temp;
                    }
                }
            }
            stopper.Stop();

            //foreach (var e in t)
            //{
            //    Console.Write($"{e} ");
            //}
            Console.WriteLine($"Eltelt idő: {stopper.ElapsedMilliseconds}");

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
