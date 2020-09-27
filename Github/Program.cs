using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg mennyi számot akar beolvasni!");
            int szama = int.Parse(Console.ReadLine());
            int[] szamok = new int[szama];
            Console.WriteLine("Kérem adjon meg 10 számot");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("{0}.szam:",i+1);
             szamok[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A be kért szamok átlaga:{0}",szamok.Average());
            Console.ReadKey();
        }
    }
}
