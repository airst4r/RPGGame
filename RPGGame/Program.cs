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
            Random rand = new Random();
            Console.WriteLine("Hello! That's my first game");
            //WeaponConstructor - baseDamage,critModificator,weaponType,penetration,presision
            //ArmorConstructor - baseArmor,bonusHealth,armorType,evasion,magicResist
            Weapon w1 = new Weapon() ;
            Armor a1 = new Armor();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(a1.ArmorInfo());
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(w1.WeaponInfo());
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
                
            }
                
            
        }
    }
}
