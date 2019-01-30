using System;

interface IWeapon
{
    private double baseDamage;
    private double critModificator;
    private string weaponType;
    private double penetration;
    private int precision;

    public double BaseDamage { }
    public double CritModificator { }
    public string WeaponType { }
    public double Penetration { }
    public int Precision { }

    public double Damage();
    public double CritDamage();
}

class Sword : IWeapon
{
    private double baseDamage;
    private double critModificator;
    private string weaponType;
    private double penetration;
    private int precision;

    public double BaseDamage { get; set; }
    public double CritModificator { get; set; }
    public string WeaponType { get; set; }
    public double Penetration { get; set; }
    public int Precision { get; set; }

    public double Damage()
    {
        Console.WriteLine("Doing damage");
    }
    public double CritDamage()
    {
        Console.WriteLine("Doing critial damage");
    }
}