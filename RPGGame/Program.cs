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
            Weapon w1 = null;
            for (int i = 0; i < 10; i++) {
                w1 = Weapon.GenerateWeapon(rand.Next(50), rand.Next(15), "Sword", rand.Next(10), rand.Next(20));
                Console.WriteLine(w1.ToString());
                i++;
            }
        }
    }
}
