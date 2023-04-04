using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja5_2023.Klasy
{
    public class Wojownik : Hero
    {

        public int Obrona;

        public Wojownik(int hp, string nazwa, int atak, int obrona) : base(hp, nazwa, atak)
        {
            Obrona = obrona;
        }
        public void OdejmijHp(int hp)
        {
            //zycieDoOdjecia – (Obrona / 3).
            Hp = Hp - (hp - (Obrona/3));
        }

        public int PobierzSileAtaku()
        {
            return Atak;
        }
    }
}
