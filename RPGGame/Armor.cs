using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Armor:IArmor
    {
        private double baseArmor;
        private string armorType;
        private double magicResist;
        private double evasion;
        private double bonusHealth;

        public double BaseArmor { get; set; }
        public double BonusHealth { get; set; }
        public string ArmorType { get; set; }
        public double Evasion { get; set; }
        public double MagicResist { get; set; }

        public Armor()
        {
            BaseArmor = 10;
            BonusHealth = 0;
            ArmorType = "Light Armor";
            Evasion = 1;
            MagicResist = 5;
        }
        public Armor(double ba) : this()
        {
            BaseArmor = ba;
        }
        public Armor(double ba, double bh) : this(ba)
        {
            BonusHealth = bh;
        }
        public Armor(double ba, double bh, string at) : this(ba, bh)
        {
            ArmorType = at;
        }

        public Armor(double ba, double bh, string at, double ev) : this(ba, bh, at)
        {
            Evasion = ev;
        }

        public Armor(double ba, double bh, string at, double ev, double mr) : this(ba, bh, at, ev)
        {
            MagicResist = mr;
        }
        public double TotalDef()
        {
            Console.WriteLine("Totally defence");
            return 1;
        }
        public bool Evade()
        {
            Console.WriteLine("Evade attack");
            return true;
        }
        public double BlockSpell()
        {
            Console.WriteLine("Block magic");
            return 1;
        }
    }
}
