using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Sword { }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! That's my first game");
            Weapon w1 = new Weapon(35,15,"Sword",7,75);
            w1.Damage();
            w1.CritDamage();
            Armor a1 = new Armor(50, 200, "Medium armor", 30, 30);
            a1.BlockSpell();
            a1.Evade();
            a1.TotalDef();
        }
    }
}
