using CSharpOOP.Abilities;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using CSharpOOP.Interfaces;
using CSharpOOP.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment.WeaponTypes;

namespace CSharpOOP.Units.Movable.Hero.Samurai
{
    public class Samurai : Hero , ISamurai
    {
        private Ability ability;
        private OmniSlash omniSlash;
        
        public OmniSlash OmniSlash
        {
            get
            {
                return omniSlash;
            }
            set
            {
                omniSlash = value;
            }
        }      
        public Blade Blade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public Samurai()
        {
            OmniSlash = new OmniSlash();
            Inventory.Item[0] = new Blade();
        }

        public static void SeeStatus(Samurai hero)
        {
            Console.WriteLine($"name:{hero.Name}\n" +
                $"health:{hero.HealthPoints}\n" +
                $"Damage: {hero.BaseDamage}\n" +
                $"armor:{hero.ArmorPoints}\n" +
                $"armorType:{hero.ArmorType}\n" +
                $"movement speed: {hero.MovementSpeed}\n" +
                $"movement type:{hero.MovementType}\n" +
                $"level: {hero.Level}\n" +
                $"skillPoints:{hero.SkillPoints}\n" +
                $"strength:{hero.Strength}\n" +
                $"agility:{hero.Agility}\n" +
                $"intelligence:{hero.Intelligence}\n" +
                $"mana: {hero.ManaPoints}\n" +
                $"Slot 1: {hero.Inventory.Item[0].ToString()}\n\n\n");
        }
        public static void SeeInventory(Samurai samurai)
        {
            Console.WriteLine($"{samurai.Inventory.Item[0]}\n" +
                              $"{samurai.Inventory.Item[1]}\n" +
                              $"{samurai.Inventory.Item[2]}\n" +
                              $"{samurai.Inventory.Item[3]}\n" +
                              $"{samurai.Inventory.Item[4]}\n" +
                              $"{samurai.Inventory.Item[5]}");
        }
        public void SkillCast(Unit target, OmniSlash OmniSlash)
        {
            OmniSlash = this.OmniSlash;
            target.HealthPoints = target.HealthPoints - (this.OmniSlash.Damage + BaseDamage);
            Console.WriteLine($"{this.Name} attacks {target.Name}\n\n");        
        }       
        public void PickUpItem(Weapon weapon, int slot)
        {
            Inventory.Item[slot] = weapon;
            BaseDamage = BaseDamage + weapon.Damage;
        }
        public void Attack()
        {
            throw new NotImplementedException();
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
