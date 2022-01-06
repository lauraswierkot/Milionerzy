using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp10
{
    public class PytanieOdpowiedz
    { 

        private string pytanie;
        private List<string> odpowiedzi;
        private string prawidlowaOdpowiedz;

        public List <string> Odpowiedzi
        {
            get { return odpowiedzi; }   
        }
        public PytanieOdpowiedz(string pytanie, List<string> odpowiedzi, string prawidlowaOdpowiedz)
        {
            this.pytanie = pytanie;
            this.odpowiedzi = odpowiedzi;
            this.prawidlowaOdpowiedz = prawidlowaOdpowiedz;
        }
        public void WyswietlPytanie()
        {
            Console.WriteLine(pytanie);
        }
        public void WyswietlOdpowiedzi()
        {
            char litera='A'; 

            for(int i = 0; i<odpowiedzi.Count; i++)
            {
                Console.WriteLine((char)(litera+i) + " " + odpowiedzi[i]);
            }
        }

        public bool SprawdzOdpowiedz(string odpowiedz)
        {
            if (odpowiedz == prawidlowaOdpowiedz)
                return true;
            else
                return false;
        }


    }
}
