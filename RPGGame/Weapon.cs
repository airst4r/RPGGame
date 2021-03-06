﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Weapon : IWeapon
    {
        private double baseDamage;
        private double critModificator;
        private string weaponType;
        private double penetration;
        private int precision;
        int rariry;
        Random rand = new Random();

        public Weapon()
        {
            BaseDamage = 10;
            CritModificator = 1;
            WeaponType = "Short Sword";
            Penetration = 10;
            Precision = 70;
        }
        public Weapon(double bd):this()
        {
            BaseDamage = bd;
        }
        public Weapon(double bd, double cm) : this(bd)
        {
            CritModificator = cm;
        }
        public Weapon(double bd,double cm,string wt) : this(bd, cm)
        {
            WeaponType = wt;
        }
        public Weapon(double bd,double cm,string wt,double pn) : this(bd, cm, wt)
        {
            Penetration = pn;
        }
        public Weapon(double bd,double cm,string wt,double pn,int pc) :this(bd, cm, wt, pn)
        {
            Precision = pc;
        }

        public double BaseDamage { get; set; }
        public double CritModificator { get; set; }
        public string WeaponType { get; set; }
        public double Penetration { get; set; }
        public int Precision { get; set; }

        public double Damage()
        {
            Console.WriteLine("Doing damage");
            return 1;
        }
        public double CritDamage()
        {
            Console.WriteLine("Doing critial damage");
            return 1.5;
        }

        public static Weapon GenerateWeapon(double bd,double cm,string wt,double pn,int pr)
        {
            return new Weapon(bd,cm,wt,pn,pr);
        }
        public override string ToString()
        {
            string result = WeaponType +" "+BaseDamage + " " + CritModificator + " " + Penetration + " " + Precision;
            return result;
        }
        public string WeaponInfo()
        {
            string creationResult = null;
            creationResult += Weapon.GenerateWeapon(rand.Next(50), rand.Next(15), "Sword", rand.Next(10), rand.Next(20));

            rariry = rand.Next((int)Enums.RareGenerator.white, (int)Enums.RareGenerator.violet);
            if (rariry < (int)Enums.RareGenerator.white)
                creationResult += " Rarity: " + Enums.RareGenerator.white;
            else if (rariry < (int)Enums.RareGenerator.green)
                creationResult += " Rarity: " + Enums.RareGenerator.green;
            else if (rariry < (int)Enums.RareGenerator.blue)
                creationResult += " Rarity: " + Enums.RareGenerator.blue;
            else if (rariry < (int)Enums.RareGenerator.orange)
                creationResult += " Rarity: " + Enums.RareGenerator.orange;
            else if (rariry < (int)Enums.RareGenerator.red)
                creationResult += " Rarity: " + Enums.RareGenerator.red;
            else
            {
                creationResult += " Rarity: " + Enums.RareGenerator.violet;
                int bonus = rand.Next((int)Enums.UniquePrefWep.Quickest, (int)Enums.UniquePrefWep.Precision);
                creationResult += " Bonus: " + Enum.GetName(typeof(Enums.UniquePrefWep), bonus);
            }
            return creationResult;
        }
    }
}
