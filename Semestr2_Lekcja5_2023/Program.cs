using Semestr2_Lekcja5_2023.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja5_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GenereujPostaci generator = new GenereujPostaci();

            Mag gracz = generator.GenerujMaga();
            Wojownik przeciwnik = generator.GenerujWojownika();

            Console.WriteLine("Na swojej drodze spotkałeś przeciwnika.");
            przeciwnik.WyswietlStatystyki();

            Console.WriteLine("Czy chcesz zaatakować (wpisz: atak) czy uciekać (wpisz: ucieczka)");
            string odp = Console.ReadLine();

            if (odp != "atak")
            {
                Console.WriteLine("Uciekasz....");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Do ataku !!!");
            // walka toczy się dopóki życie któregoś z graczy nie spadnie poniżej zera
            while (gracz.Hp >= 0 && przeciwnik.Hp >= 0)
            {
                // przeciwnik atakuje
                Console.WriteLine($"Gracz {przeciwnik.Nazwa} atakuje.");
                int atakPrzeciwnika = przeciwnik.PobierzSileAtaku();
                gracz.OdejmijHp(atakPrzeciwnika);
                Console.WriteLine($"Pozostało Ci {gracz.Hp} życia.\n");
                // sprawdzamy czy po ataku czasem nie zginęliśmy
                // jeżeli tak to kończymy walkę
                if (gracz.Hp <= 0)
                    break;
                // zatrzymujemy na pół sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);
                // my atakujemy
                Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
                int atakGracza = gracz.PobierzSileAtaku();
                przeciwnik.OdejmijHp(atakGracza);
                Console.WriteLine($"Przeciwnikowi zostało {przeciwnik.Hp} życia.\n");
                // sprawdzamy czy po ataku czasem nie pokonaliśmy wroga
                // jeżeli tak to kończymy walkę
                if (przeciwnik.Hp <= 0)
                    break;
                // zatrzymujemy na pół sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);
            }
            if (gracz.Hp <= 0)
            {
                Console.WriteLine($"Niestety zostałeś pokonany. Przeciwnik {przeciwnik.Nazwa} wygrał.");
            }
            else
            {
                Console.WriteLine($"Gratulację. Pokonałeś przeciwnika {przeciwnik.Nazwa}");
            }
            Console.ReadKey();
        }
    }
}
