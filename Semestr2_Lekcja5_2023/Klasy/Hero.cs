using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja5_2023.Klasy
{
    public class Hero
    {
        public int Hp;
        public string Nazwa;
        public int Atak;

        public Hero(int hp, string nazwa, int atak)
        {
            Hp = hp;
            Nazwa = nazwa;
            Atak = atak;
        }
        
        public void WyswietlStatystyki()
        {
            Console.WriteLine($"Postać {Nazwa} posiada {Hp} życia i {Atak} ataku.");
        }
    }
}
