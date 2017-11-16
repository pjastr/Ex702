using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex702
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan", "Kowalski", 1990));
            osoby.Add(new Osoba("Anna", "Nowak", 1990));
            osoby.Add(new Osoba("Anna", "Nowacka", 1996));
            osoby.Add(new Osoba("Tomasz", "Kowalski", 1998));
            osoby.Add(new Osoba("Jakub", "Wolski", 1992));
            osoby.Add(new Osoba("Justyna", "Kowalska", 1991));
            osoby.Add(new Osoba("Alicja", "Krawiec", 1999));
            osoby.Add(new Osoba("Tomasz", "Nowak", 1998));
            osoby.Add(new Osoba("Jan", "Kowalski", 1994));
            osoby.Sort();
            foreach(var element in osoby)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();
        }
    }
}
