using System.Numerics;
using System;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.WeaponTypes.Sharp;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Units.Movable;
using CSharpOOP.Enumerations;
using CSharpOOP.Units;
using CSharpOOP.Units.Movable;
using CSharpOOP.Units.Movable.Hero;
using CSharpOOP.Units.Movable.Hero.Samurai;

namespace CSharpOOP
{
    public class EntryPoint
    {
        
        static void Main()
        {
            Samurai hero = new Samurai();
            Samurai hero2 = new Samurai();
            Samurai.SeeStatus(hero);
            Samurai.SeeStatus(hero2);

            hero.SkillCast(hero2, hero.OmniSlash);

            Samurai.SeeStatus(hero2);
        }
    }
}