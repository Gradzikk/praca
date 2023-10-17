using System;
using System.Collections.Generic;
using System.Security.Cryptography;

class Program
{
    static List<string> lista = new List<string>();

    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Dodaj złotą myśl");
            Console.WriteLine("2. Edytuj złotą myśl");
            Console.WriteLine("3. Usuń złotą myśl");
            Console.WriteLine("4. Losuj złotą myśl");
            Console.WriteLine("5. Wyświetl złote myśli");
            Console.WriteLine("6. Wyjście");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1": DodajTekst(); break;
                case "2": EdytujTekst(); break;
                case "3": UsunTekst(); break;
                case "4": Losuj(); break;
                case "5": Console.WriteLine("Złote myśli :"); for (int i = 0; i < lista.Count; i++) { Console.WriteLine($"{i + 1}. {lista[i]}"); } break;
                case "6": Environment.Exit(0); break;
                default: Console.WriteLine("Zła odpowiedź, spróbuj ponownie"); break;
            }
        }
    }

    static void DodajTekst()
    {
        Console.WriteLine("Wpisz tekst, który ma być dodany:");
        string tekst = Console.ReadLine();
        lista.Add(tekst);
        Console.WriteLine("Tekst został dodany.");
    }

    static void EdytujTekst()
    {
        Console.WriteLine("Podaj, którą złotą myśl chcesz edytować:");
        if (int.TryParse(Console.ReadLine(), out int indeks) && indeks >= 0 && indeks < lista.Count)
        {
            Console.WriteLine("Wprowadź nowy tekst:");
            string nowyTekst = Console.ReadLine();
            lista[indeks] = nowyTekst;
            Console.WriteLine("Tekst został zaktualizowany.");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer.");
        }
    }

    static void UsunTekst()
    {
        Console.WriteLine("Podaj, którą złotą myśl chcesz usunąć:");
        if (int.TryParse(Console.ReadLine(), out int indeks) && indeks >= 0 && indeks < lista.Count)
        {
            lista.RemoveAt(indeks);
            Console.WriteLine("Tekst został usunięty.");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer.");
        }
    }


        static void Losuj()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Brak złotych myśli");
            }
            else
            {
                Random random = new Random();
                int losowy = random.Next(lista.Count);
                string losowa = lista[losowy];
                Console.WriteLine("Losowa złota myśl: " + losowa);
            }
        }
    }



    
