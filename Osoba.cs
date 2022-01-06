using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        
        public string ImieNazwisko()
        {
            return imie + " " + nazwisko;
        }

    }
}
