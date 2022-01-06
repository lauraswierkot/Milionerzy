using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Laura\text.txt";
            string filePathSave = @"C:\Users\Laura\results.txt";


            Console.WriteLine("Gra: Milionerzy");
            Console.WriteLine("Podaj swoje imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj swoj wiek");
            int wiek = int.Parse(Console.ReadLine());

            Osoba gracz = new Osoba(imie, nazwisko, wiek);


            string odpowiedzUsera;
            int punkty=0;

            string[] liniePytan = File.ReadAllLines(filePath);

            List<PytanieOdpowiedz> pytania = new List<PytanieOdpowiedz>();
            List<PytanieOdpowiedz> randomowePytania = new List<PytanieOdpowiedz>();


            for (int i = 0; i < liniePytan.Length-1; i+=3)
            {
                PytanieOdpowiedz pytanieOdpowiedz = new PytanieOdpowiedz(liniePytan[i], liniePytan[i+1].Split(' ').ToList(), liniePytan[i+2]);
                pytania.Add(pytanieOdpowiedz);
            }

            randomowePytania = pytania.OrderBy(pytanie => Guid.NewGuid()).Take(6).ToList();

            for(int i = 0; i<randomowePytania.Count; i++)
            {
                randomowePytania[i].WyswietlPytanie();
                randomowePytania[i].WyswietlOdpowiedzi();
                odpowiedzUsera = Console.ReadLine();

                string odp = "";

                switch (odpowiedzUsera) 
                {
                    case "A":
                        odpowiedzUsera = randomowePytania[i].Odpowiedzi[0];
                        break;
                    case "B":
                        odpowiedzUsera = randomowePytania[i].Odpowiedzi[1];
                        break;
                    case "C":
                        odpowiedzUsera = randomowePytania[i].Odpowiedzi[2];
                        break;
                    case "D":
                        odpowiedzUsera = randomowePytania[i].Odpowiedzi[3];
                        break;
                    default:
                        Console.WriteLine("Niepoprawna odpowiedz");
                        break;
                }
                if (randomowePytania[i].SprawdzOdpowiedz(odpowiedzUsera) == false)
                {
                    Console.WriteLine("Przegrales glombie");
                    break;

                }
                else 
                { 
                    Console.WriteLine("Dobra odpowiedz!");
                    punkty++;
                }
            }

            Console.WriteLine("Wynik: " + punkty);

            Wynik wynik = new Wynik(gracz, punkty);
            File.AppendAllText(filePathSave, wynik.ZwrocWynik());
            

            Console.ReadLine();




        }
    }
}
