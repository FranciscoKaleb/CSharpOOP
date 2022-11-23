using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Equipment.WeaponTypes.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.Melee
{
    public class Assassin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private Dagger weapon;
        private Chainlink armor;


        public int AbilityPoints 
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if(value >= 0)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty,"Ability Points cannot be negative");
                }
                
            }
        }
        public int HealthPoints 
        {
            get 
            { 
                return healthPoints; 
            } 
            set 
            {

                if (value >= 0)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health Points cannot be negative");
                }
            } 
        }
        public int Level 
        { 
            get
            {
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "level cannot be negative");
                }
            }
        }
        public string Faction 
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "melee")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Assassin faction should be melee");
                }
            }
        }
        public string Name 
        {
            get 
            { 
                return name; 
            }
            set 
            {
                if (value.Length <= 20)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty,"Name cannot exceed 20 characters");
                }
                
            } 
        }
        public Dagger Weapon 
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
        public Chainlink Armor 
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }

        public Assassin()
        {

        }

        public void Greetings(String name)
        {
            Console.WriteLine("I am "+this.name+", Hello "+name+" "); // example of using this
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
