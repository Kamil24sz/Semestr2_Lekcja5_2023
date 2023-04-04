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

            Mag mag = generator.GenerujMaga();

            Wojownik woj = generator.GenerujWojownika();


            mag.WyswietlStatystyki();
            woj.WyswietlStatystyki();

            //do zadania 12
            Console.ReadLine();
        }
    }
}
