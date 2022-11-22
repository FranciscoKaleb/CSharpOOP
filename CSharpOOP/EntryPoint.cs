using System.Numerics;
using System;
using CSharpOOP.Characters.Melee;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.WeaponTypes.Sharp;

namespace CSharpOOP
{
    public class EntryPoint
    {
        
        static void Main()
        {
            Sword sword1 = new Sword();
            Warrior goodGuy = new Warrior();

            goodGuy.AbilityPoints = 2;
            goodGuy.Faction = "Righteous";
            goodGuy.HealthPoints = 500;
            goodGuy.Level = 1;
            goodGuy.Name = "David";
            goodGuy.Weapon = sword1;

            sword1.BloodThirst();
        }
    }
}