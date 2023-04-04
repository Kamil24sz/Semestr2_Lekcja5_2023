using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja5_2023.Klasy
{
    public class GenereujPostaci
    {
        private Random LiczbyLosowe;
        string[] Imiona = new string[] { "Vladimir", "Nieznajomy", "Max", "Veigar", "Gerard" };

        public GenereujPostaci()
        {
            LiczbyLosowe = new Random();
        }
        public Mag GenerujMaga()
        {
            int hp = LiczbyLosowe.Next(150,300);
            int atak = LiczbyLosowe.Next(5,15);
            string imie = Imiona[LiczbyLosowe.Next(0, Imiona.Length)];
            int moc = LiczbyLosowe.Next(5, 10);

            Mag mag = new Mag(hp, imie, atak, moc);
            return mag;
        }

        public Wojownik GenerujWojownika()
        {
            int hp = LiczbyLosowe.Next(150, 300);
            int atak = LiczbyLosowe.Next(5, 15);
            string imie = Imiona[LiczbyLosowe.Next(0, Imiona.Length)];
            int obrona = LiczbyLosowe.Next(5, 10);

            Wojownik woj = new Wojownik(hp, imie, atak, obrona);
            return woj;
        }

    }
}
