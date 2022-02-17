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
            void DodajZwierze();
            {
                string nazwa;
                do
                {
                    Console.WriteLine("");
                    nazwa = Console.ReadLine().ToLower();
                } while (nazwa == "");
                if (nazwa == "stop") ;
                {
                    koniec = true;
                    return;
                }
                string roznica;
                do
                {
                    Console.WriteLine("Czym różni się " + nazwa + " od zwierzęcia o nazwie " + aktywnePytanie.tresc);
                    roznica = Console.ReadLine().ToLower();
                } while (roznica == "");
                if (roznica == "stop")
                {
                    koniec = true;
                    return;
                }
                aktywnePytanie.tak = new Pytanie(nazwa, false);
                aktywnePytanie.nie = new Pytanie(aktywnePytanie.tresc, false);
                aktywnePytanie.tresc = roznica;
                aktywnePytanie.cecha = true;
            }
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
                        do
                        {
                            Console.WriteLine("Czy to zwierzę " + aktywnePytanie.tresc + "?");
                            odpowiedz
                        }
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
                        {
                            Console.WriteLine("Hurra! Zgadłem!")
                        }
                        else
                        {
                            Console.WriteLine("")
                        }
                    }
                } while (fazaPytan && !koniec);

            } while (!koniec);
        }
    }
}
    