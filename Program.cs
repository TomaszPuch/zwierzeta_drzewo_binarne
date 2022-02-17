using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_22
{
    class Program
    {
        class Pytanie
        {
            public string tresc;
            public bool cecha;
            public Pytanie tak, nie; 
            
            public Pytanie(string _tresc, bool _cecha)
            {
                tresc = _tresc;
                cecha = _cecha;
            }
        }
        static void Main(string[] args)
        {
            //zmienne
            Pytanie poczatek, aktywnePytanie;
            bool koniec = false, fazaPytan;
            string odpowiedz;

            //funkcje

            //program
            poczatek = new Pytanie("kot", false);
            Console.WriteLine("ten program probuje zgadnac o jakim zwierzeciu myslisz.");

            do //petla glowna
            {
                fazaPytan = true;
                aktywnePytanie = poczatek;
                Console.WriteLine();
                Console.WriteLine("Zaczynamy! Pomyśl o jakimś zwierzęciu.");
                Console.WriteLine("Jeśli chcesz zakończyć działanie aplikacji wpisz \"stop\".");
                Console.WriteLine();
                do //faza pytan
                {
                    if (aktywnePytanie.cecha) //pytamy o roznice
                    {

                    }
                    else
                    {
                        fazaPytan = false;
                        Console.WriteLine("Czy zwierzę o którym myślisz to " + aktywnePytanie.tresc + "? (tak/nie)");
                        odpowiedz = Console.ReadLine().ToLower();
                    } while (odpowiedz != "tak" && odpowiedz != "nie" && odpowiedz != "stop");
                    if (odpowiedz == "stop") koniec = true;
                    else
                    {
                        if (odpowiedz == "tak") //zgadlismy
                    }
                } while (fazaPytan && !koniec);

            } while (!koniec);
        }
    }
}
    