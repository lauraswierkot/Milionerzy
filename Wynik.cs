using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Wynik
    {
        Osoba osoba;
        int wynik;

        public Wynik(Osoba osoba, int wynik)
        {
            this.osoba = osoba;
            this.wynik = wynik;
        }

        public string ZwrocWynik()
        {
            return "Gracz Dane: " + osoba.ImieNazwisko() + " Wynik: " + wynik + " Data gry: " + DateTime.Now + "\n";
        }
    }
}
