using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Equipment.WeaponTypes.Sharp;

namespace CSharpOOP.Characters.Melee
{
    public class Warrior
    {
        
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private Axe weapon;
        private Chainlink armor;


        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points cannot be negative");
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
                if (value.Length < 20)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "name must only contain max of 20 characters");
                   // Console.WriteLine("name must only contain max of 20 characters");
                }
                
            }
        }
        public Axe Weapon 
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

        public Warrior()
        {

        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
