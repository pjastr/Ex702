using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex702
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int rok;

        public Osoba(string imie, string nazwisko, int rok)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok = rok;
        }

        public override string ToString()
        {
            return imie+" "+nazwisko+" "+rok;
        }
    }
}
