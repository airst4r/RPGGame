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
                int rare;
                string result = null;
                w1 = Weapon.GenerateWeapon(rand.Next(50), rand.Next(15), "Sword", rand.Next(10), rand.Next(20));
                result += w1.ToString();
                rare = rand.Next((int)Enums.RareGenerator.white, (int)Enums.RareGenerator.violet);
                if (rare < (int)Enums.RareGenerator.white)
                    result += " Rarity: " + Enums.RareGenerator.white;
                else if (rare < (int)Enums.RareGenerator.green)
                    result += " Rarity: " + Enums.RareGenerator.green;
                else if (rare < (int)Enums.RareGenerator.blue)
                    result += " Rarity: " + Enums.RareGenerator.blue;
                else if (rare < (int)Enums.RareGenerator.orange)
                    result += " Rarity: " + Enums.RareGenerator.orange;
                else if (rare < (int)Enums.RareGenerator.red)
                    result += " Rarity: " + Enums.RareGenerator.red;
                else result += " Rarity: " + Enums.RareGenerator.violet;
                //ПРОВЕРИТЬ - не добавляет бонус при фиолетовом рарити
                if (rare == (int)Enums.RareGenerator.violet)
                {
                    int bonus = rand.Next((int)Enums.UniquePrefWep.Quickest, (int)Enums.UniquePrefWep.Precision);
                    result += " Bonus: " + Enum.GetName(typeof(Enums.UniquePrefWep), bonus);
                }

                Console.WriteLine(new string('-',30));
                Console.WriteLine(result);
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
            }
        }
    }
}
