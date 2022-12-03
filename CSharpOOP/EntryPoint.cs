using System.Numerics;
using System;
using CSharpOOP.Characters.Melee;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.WeaponTypes.Sharp;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Characters.SpellCasters;
using CSharpOOP.Enumerations;

namespace CSharpOOP
{
    public class EntryPoint
    {
        
        static void Main()
        {
            Warrior warrior = new Warrior("Tulfo", 17, 76, 175, Faction.Chaos);
            Warrior.GetWarriorInfo(warrior);

        }
    }
}