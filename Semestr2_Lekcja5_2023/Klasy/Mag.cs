using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja5_2023.Klasy
{
    public class Mag : Hero
    {
        public int Moc;

        public Mag(int hp, string nazwa, int atak, int moc) : base(hp, nazwa, atak)
        {
            Moc = moc;
        }

        public void OdejmijHp(int hp)
        {
            Hp = Hp - hp;
        }
        public int PobierzSileAtaku()
        {
            //Atak + (Moc / 5).
            return Atak + (Moc / 5);
        }
    }
}
