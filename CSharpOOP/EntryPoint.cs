using System.Numerics;
using System;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Units.Movable;
using CSharpOOP.Enumerations;
using CSharpOOP.Units;
using CSharpOOP.Units.Movable;
using CSharpOOP.Units.Movable.Hero;
using CSharpOOP.Units.Movable.Hero.Samurai;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using CSharpOOP.Abilities.Hero.Samurai;
using CSharpOOP.Abilities;
using System.Diagnostics;

namespace CSharpOOP
{
    public class EntryPoint
    {

        static void Main()
        {
            ItemAcquiringScenario();
        }
        
        public void SkillCastingScenario()
        {
            // Creation of 2 Samurai Objects
            Samurai hero = new Samurai();
            Samurai hero2 = new Samurai();

            // Setting name for the objects
            hero.Name = "first Samurai";
            hero2.Name = "second Samurai";

            // Outputs the members of Samurai Objects
            Samurai.SeeStatus(hero);
            Samurai.SeeStatus(hero2);

            //giving/leveling up skill

            //casting skill

            //seeTargetStatus

        }  //not good
        public static void ItemAcquiringScenario()
        {
            Samurai samurai = new Samurai();

            Blade blade = new Blade();
            Chainlink chainlink = new Chainlink();

            Hero.SeeStatus(samurai);

            samurai.PickUpItem(blade);
            samurai.PickUpItem(chainlink);

            Hero.SeeStatus(samurai);
           
        } //goods
        public static void CreatingListOfHeroScenario()
        {
            List<Hero> heroList = new List<Hero>();
            Hero samurai = new Samurai();
            Hero musashi = new Musashi();
            Hero kenshin = new Kenshin();

            kenshin.Greetings();
            samurai.Greetings();
            musashi.Greetings();
        }  //goods
        public static void GivingAbilitiesToHeroesScenario()
        {
            // created two samurai object
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();

            //give those object a name
            samurai1.Name = "Musashi";
            samurai2.Name = "Kenshin";

            //give object one an ability
            samurai1.AbilitySlot.Ability[0] = new OmniSlash();

            // see target opponent hp
            Samurai.SeeStatus(samurai2);
            
            //cast skill on opponent
            samurai1.SkillCast(samurai2, samurai1.AbilitySlot.Ability[0]);

            // see target hp after casting skill
            Samurai.SeeStatus(samurai2);
           
        } //not good
        public static void fightScenario() 
        {
            Samurai samurai = new Samurai();
            Musashi musashi = new Musashi();
            samurai.AbilitySlot.Ability[0] = new OmniSlash();
            musashi.AbilitySlot.Ability[0] = new OmniSlash();
            samurai.Inventory.Item[0] = new Blade();
            musashi.Inventory.Item[0] = new Blade();
            samurai.HealthPoints = samurai.HealthPoints + 3000;
            samurai.Name = "samurai";
            musashi.HealthPoints = musashi.HealthPoints + 2000;
            musashi.Name = "musashi";
            Hero.SeeStatus(musashi);
            Hero.SeeStatus(samurai);
            for (int x = 0; x < 5; x++)
            {
                //samurai.Attack(musashi);
                //musashi.Attack(samurai);
            }          
            Hero.SeeStatus(musashi);
            Hero.SeeStatus(samurai);

        }//not good
        public static void gainingExpScenario()
        {
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();
            Samurai samurai3 = new Samurai();
            Samurai samurai4 = new Samurai();
            Samurai samurai5 = new Samurai();
            samurai1.Name = "Naruto";
            samurai2.Name = "Sasuke";
            Blade blade1 = new Blade();
            samurai1.Inventory.Item[0] = blade1;
            samurai2.HealthPoints = 1000;
            samurai1.AttackSpeed = 300;
            Console.WriteLine($"{samurai1.Name} experience points: {samurai1.ExperiencePoints}\n");
            samurai1.Attack(samurai2, true);
            Console.WriteLine($"{samurai1.Name} experience points: {samurai1.ExperiencePoints}");
            samurai1.Attack(samurai3, true);
            Console.WriteLine($"{samurai1.Name} experience points: {samurai1.ExperiencePoints}");
            samurai1.Attack(samurai4, true);
            Console.WriteLine($"{samurai1.Name} experience points: {samurai1.ExperiencePoints}");
        }//not good
        public static void attackSpeedScenario()
        {
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();
            samurai1.Name = "Goruto";
            samurai2.Name = "Sasuke";

            samurai2.HealthPoints = 100;
            samurai1.AttackSpeed = 300;
            
            samurai1.Attack(samurai2, true);
            
            
            
        } //Done
        public static void armorDamageReductionScenario()
        {
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();

            samurai1.Name = "Goruto";
            samurai2.Name = "Sasuke";

            samurai2.HealthPoints = 100;
            samurai1.AttackSpeed = 300;

            samurai2.ArmorPoints = 3;

            samurai1.Attack(samurai2, true);
        }//goods
        public static void criticalStrikeChanceScenario()
        {
            Samurai samurai = new Samurai();
            Samurai samurai2 = new Samurai();
            samurai2.ArmorPoints = 4;
            samurai2.HealthPoints = 500;

            Console.WriteLine($"Object 2 Health: {samurai2.HealthPoints}");
            while (samurai2.HealthPoints > 0)
            {
                samurai.Attack2(samurai2);
                Console.WriteLine($"HP: {samurai2.HealthPoints}");
                Thread.Sleep(samurai.AttackSpeed-500);
            }
            
        }//goods
    }
}