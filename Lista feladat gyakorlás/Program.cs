using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_feladat_gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // számok generálása

            int db = 10;
            List<int> szamok = new List<int>();
            Random random = new Random();


            Console.WriteLine("számok: ");
            for (int i = 0; i < db; i++)
            {
                szamok.Add(random.Next(0, 101));
                Console.Write($"{szamok[i]}, ");
            }

            //4.)

            Console.WriteLine("\r\n 4. feladat: ");
            for (int x = 0; x < szamok.Count; x++)
            {
                for (int y = x + 1; y < szamok.Count; y++)
                {
                    if (szamok[x] == szamok[y])
                    {
                        szamok.RemoveAt(x);
                    }
                }
            }
            
            foreach (int i in szamok)
            {
                Console.Write($"{i}, ");
            }

            //3.)

            //List<int> szamok = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("\r\n 3. feladat: ");
            Console.WriteLine("Prím számok a listában:");
            foreach (int i in szamok)
            {
                if (IsPrim(i))
                {
                    Console.Write($"{i}, ");
                }

            }

            //2.)

            List<string> szavak = new List<string> { "cipő", "nokedli", "megszentségteleníthetetlenségeskedéseitekért", "szilva", "eper", "á" };
            Console.WriteLine("\r\n\r\nszavak: ");
            foreach (string szo in szavak)
            {
                Console.Write($"{szo}, ");
            }


            Console.WriteLine("\r\n 2. feladat: ");

            double atlag = AtlagHossz(szavak);
            int hosszu = HosszOsszeg(szavak);

            Console.WriteLine("Szavak átlagos hossza: " + atlag);
            Console.WriteLine("Leghosszabb szó hossza: " + hosszu);


            //vége
            Console.WriteLine("\r\n\r\n Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }

        static double AtlagHossz(List<string> szavak)
        {
            if (szavak.Count == 0)
                return 0;

            int osszHossz = 0;
            foreach (var szo in szavak)
            {
                osszHossz += szo.Length;
            }
            double atlag = 0.0;
            atlag = (double)osszHossz / (double)szavak.Count;
            return atlag;
        }

        static int HosszOsszeg(List<string> szavak)
        {
            if (szavak.Count == 0)
                return 0;

            int legHosszabb = 0;
            foreach (var szo in szavak)
            {
                if (szo.Length > legHosszabb)
                {
                    legHosszabb = szo.Length;
                }
            }
            return legHosszabb;
        }

        static bool IsPrim(int szam)
        {
            if (szam <= 2)
            {
                return false;
            }
            for (int i = 2; i + i < szam; i++)
            {
                if (szam % i == 0)
                {
                    return false;
                }
            }
            return true;

        
        }
    }
}
   
