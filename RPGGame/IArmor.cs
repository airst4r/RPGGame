using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    interface IArmor
    {
        double BaseArmor { get; set; }
        string ArmorType { get; set; }
        double BonusHealth { get; set; }
        double MagicResist { get; set; }
        double Evasion { get; set; }
        double TotalDef();
        bool Evade();
        double BlockSpell();
    }
}
