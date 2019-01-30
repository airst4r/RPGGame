using System;
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
    }
}
