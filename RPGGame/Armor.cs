using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Armor:IArmor
    {
        Random rand = new Random();
        private int rarity;
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
        public override string ToString()
        {
            string result = BaseArmor + " " + BonusHealth + " " + ArmorType + " " + Evasion + " " + MagicResist;
            return result;
        }
        public Armor GenerateArmor(double ba, double bh, string at, double ev, double mr)
        {
            return new Armor(ba, bh, at, ev, mr);
        }
        public string ArmorInfo()
        {
            string creationResult = null;
            creationResult += this.GenerateArmor(rand.Next(50), rand.Next(15), "Torse", rand.Next(10), rand.Next(20));
            rarity = rand.Next((int)Enums.RareGenerator.white, (int)Enums.RareGenerator.violet);
            if (this.rarity < (int)Enums.RareGenerator.white)
                creationResult += " Rarity: " + Enums.RareGenerator.white;
            else if (this.rarity < (int)Enums.RareGenerator.green)
                creationResult += " Rarity: " + Enums.RareGenerator.green;
            else if (this.rarity < (int)Enums.RareGenerator.blue)
                creationResult += " Rarity: " + Enums.RareGenerator.blue;
            else if (this.rarity < (int)Enums.RareGenerator.orange)
                creationResult += " Rarity: " + Enums.RareGenerator.orange;
            else if (this.rarity < (int)Enums.RareGenerator.red)
                creationResult += " Rarity: " + Enums.RareGenerator.red;
            else
            {
                creationResult += " Rarity: " + Enums.RareGenerator.violet;
                int bonus = rand.Next((int)Enums.UniquePerfArm.Impenetrable, (int)Enums.UniquePerfArm.Tenacious);
                creationResult += " Bonus: " + Enum.GetName(typeof(Enums.UniquePerfArm), bonus);
            }
            return creationResult;
        }
    }
}
