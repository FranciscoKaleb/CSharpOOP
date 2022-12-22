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
using CSharpOOP.Equipment.WeaponTypes.Sword;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Abilities;
using System.Diagnostics;

namespace CSharpOOP
{
    public class EntryPoint
    {

        static void Main()
        {
            criticalStrikeChanceScenario();
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

            // Casting skill of samurai 1 to samurai 2
            hero.SkillCast(hero2, hero.OmniSlash);

            // Outputs the status of hero2 reduced damage
            Samurai.SeeStatus(hero2);
        } // logic of Basic Skill Casting
        public static void ItemAcquiringScenario()
        {
            string x = "";
            Samurai samurai = new Samurai();
            Console.WriteLine("Set name for the Character:\n");
            samurai.Name = Console.ReadLine();
            Console.WriteLine($"hello {samurai.Name}\n " +
                $"here is the list of items \n" +
                $"type the item number of your chosen item \n" +
                $"you have total of 6 inventory slots\n" +
                $"1. Blade \n" +
                $"2. Mirror \n" +
                $"3. Chainmail \n" +
                $"4. helmet \n" +
                $"5. Sword \n" +
                $"6. Boots \n");           
                for (int slot = 0; slot < samurai.Inventory.Item.Length; slot++)
                {
                    Console.WriteLine($"Choose an item for item Slot {slot+1}\n");
                    x = Console.ReadLine();
                    if (x == "1")
                    {
                        samurai.PickUpItem(new Blade(samurai), slot);
                    }
                    if (x == "5")
                    {
                        samurai.PickUpItem(new Sword(), slot);
                    }
                }
            Samurai.SeeStatus(samurai);
            
        } //logic of Object creation
        public static void CreatingListOfHeroScenario()
        {
            List<Hero> heroList = new List<Hero>();
            Hero samurai = new Samurai();
            Hero musashi = new Musashi();
            Hero kenshin = new Kenshin();

            kenshin.Greetings();
            samurai.Greetings();
            musashi.Greetings();
        } //Application of Polymorphism
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
           
        } // logic of ability slot function
        public static void fightScenario() 
        {
            Samurai samurai = new Samurai();
            Musashi musashi = new Musashi();
            samurai.AbilitySlot.Ability[0] = new OmniSlash();
            musashi.AbilitySlot.Ability[0] = new OmniSlash();
            samurai.Inventory.Item[0] = new Blade(samurai);
            musashi.Inventory.Item[0] = new Blade(musashi);
            samurai.HealthPoints = samurai.HealthPoints + 3000;
            samurai.Name = "samurai";
            musashi.HealthPoints = musashi.HealthPoints + 2000;
            musashi.Name = "musashi";
            Hero.SeeStatus(musashi);
            Hero.SeeStatus(samurai);
            for (int x = 0; x < 5; x++)
            {
               // samurai.Attack(musashi);
               // musashi.Attack(samurai);
            }          
            Hero.SeeStatus(musashi);
            Hero.SeeStatus(samurai);

        }// logic of two units taking damage
        public static void gainingExpScenario()
        {
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();
            Samurai samurai3 = new Samurai();
            Samurai samurai4 = new Samurai();
            Samurai samurai5 = new Samurai();
            samurai1.Name = "Naruto";
            samurai2.Name = "Sasuke";
            Blade blade1 = new Blade(samurai1);
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
        }//Done
        public static void itemGainingDamagePerKillScenario()
        {
            Samurai samurai1 = new Samurai();
            Samurai samurai2 = new Samurai();
            samurai1.Name = "Naruto";
            samurai2.Name = "Sasuke";
            Blade blade1 = new Blade(samurai1);
            samurai1.Inventory.Item[0] = blade1;
            Console.WriteLine($"Naruto blade damage: {blade1.Damage}\n");
            
            samurai2.HealthPoints = 1000;
            samurai1.AttackSpeed = 300;

            samurai1.Attack(samurai2, true);
            blade1.Damage = blade1.Damage + 10;

            Console.WriteLine($"Naruto blade damage: {blade1.Damage}");
        } //Done
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



        }//Done
        public static void criticalStrikeChanceScenario()
        {
            Samurai samurai = new Samurai();
            Samurai samurai2 = new Samurai();
            samurai2.HealthPoints = 500;
            Console.WriteLine($"Object 2 Health: {samurai2.HealthPoints}");
            while (samurai2.HealthPoints>0)
            {
                samurai.Attack2(samurai2);
                Console.WriteLine($"HP: {samurai2.HealthPoints}");
                Thread.Sleep(samurai.AttackSpeed-500);
            }
            
        }//Done
        public static void movementScenario()
        {

        }
        public static void stopMovingScenario()
        {

        }
    }
}