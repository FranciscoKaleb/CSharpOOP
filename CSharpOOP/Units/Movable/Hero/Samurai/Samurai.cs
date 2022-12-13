using CSharpOOP.Abilities;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using CSharpOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable.Hero.Samurai
{
    public class Samurai : Hero , ISamurai
    {
        private Blade weapon;
        private Ability ability;
        private OmniSlash omniSlash;

        public Blade Weapon
        {
            get 
            { 
                return weapon; 
            }
            set 
            { 
                weapon = value;
            }
        }
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
            Weapon = new Blade();
            OmniSlash = new OmniSlash();
            
        }

        public static void SeeStatus(Samurai hero)
        {
            Console.WriteLine($"name:{hero.Name}\n" +
                $"health:{hero.HealthPoints}\n" +
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
                $"weapon: {hero.Weapon}\n\n\n");
        }
        public void SkillCast(Unit target, OmniSlash OmniSlash)
        {
            OmniSlash = this.OmniSlash;
            target.HealthPoints = target.HealthPoints - (this.OmniSlash.Damage + Weapon.Damage);
            Console.WriteLine($"{this.Name} attacks {target.Name}\n\n");        
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
