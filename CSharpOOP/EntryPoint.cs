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

            // Casting skill of samurai 1 to samurai 2
            hero.SkillCast(hero2, hero.OmniSlash);

            // Outputs the status of hero2 reduced damage
            Samurai.SeeStatus(hero2);
        }

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
                for (int a = 0; a < samurai.Inventory.Item.Length; a++)
                {
                    Console.WriteLine($"Choose an item for item Slot {a+1}\n");
                    x = Console.ReadLine();
                    if (x == "1")
                    {
                        samurai.PickUpItem(new Blade(), a);
                    }
                    if (x == "5")
                    {
                        samurai.PickUpItem(new Sword(), a);
                    }
                }
            Samurai.SeeInventory(samurai);
            Samurai.SeeStatus(samurai);
            
        }

        public static void PickingUpItemScenario()
        {

        }
    }
}