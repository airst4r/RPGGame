using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    interface IWeapon
    {

        double BaseDamage { set; get; }
        double CritModificator { set; get; }
        string WeaponType { set; get; }
        double Penetration { set; get; }
        int Precision { set; get; }

        double Damage();
        double CritDamage();
    }
}
