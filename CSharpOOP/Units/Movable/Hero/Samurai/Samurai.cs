using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable.Hero.Samurai
{
    public class Samurai : Hero
    {
        private Blade weapon;
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

        public void SkillCast(Unit unit, OmniSlash OmniSlash)
        {
            OmniSlash = this.OmniSlash;
            unit.HealthPoints = unit.HealthPoints - this.OmniSlash.Damage;
            Console.WriteLine($"{this.Name} attacks {unit.Name}");
            
        }
    }
}
