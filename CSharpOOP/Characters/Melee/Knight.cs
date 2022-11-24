using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Equipment.WeaponTypes.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.Melee
{
    internal class Knight
    {
        // FIELDS
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;

        private string name;
        private int age;
        private int height;
        private int weight;

        private Sword weapon;
        private Chainlink armor;

        // PROPERTIES
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.abilityPoints = value;
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
                return this.healthPoints;
            }
            set
            {

                if (value >= 0)
                {
                    this.healthPoints = value;
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
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
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
                return this.faction;
            }
            set
            {
                if (value == "melee")
                {
                    this.faction = value;
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
                return this.name;
            }
            set
            {
                if (value.Length <= 20)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Name cannot exceed 20 characters");
                }

            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Sword Weapon 
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            } 
        }
        public Chainlink Armor 
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }

        //CONSTRUCTORS
        public Knight()
            : this("Young Knight")
        {

        }
        public Knight(string name)
            : this(name, 18)
        {

        }
        public Knight(string name, int age)
            : this(name, age, 170)
        {

        }
        public Knight(string name, int age, int height)
            : this(name, age, height, 65)
        {

        }
        public Knight(string name, int age, int height, int weight)
            : this(name, age, height, weight, new Sword())
        {

        }
        public Knight(string name, int age, int height, int weight, Sword weapon)
            : this(name, age, height, weight, weapon, new Chainlink())
        {

        }
        public Knight(string name, int age, int height, int weight, Sword weapon, Chainlink armor)
            : this(name, age, height, weight, weapon, armor,"melee")
        {

        }
        public Knight(string name, int age, int height, int weight, Sword weapon, Chainlink armor, string faction)
            : this(name, age, height, weight, weapon, armor, faction, 10)
        {
            
        }
        public Knight(string name, int age, int height, int weight, Sword weapon, Chainlink armor, string faction, int abilityPoints)
            : this(name, age, height, weight, weapon, armor, faction, abilityPoints, 100)
        {
            
        }
        public Knight(string name, int age, int height, int weight, Sword weapon, Chainlink armor, string faction, int abilityPoints, int healthPoints)
            : this(name, age, height, weight, weapon, armor, faction, abilityPoints, healthPoints, 1)
        {
          
        }
        public Knight(string name, int age, int height, int weight, Sword weapon, Chainlink armor, string faction, int abilityPoints, int healthPoints, int level)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.weapon = weapon;
            this.armor = armor;
            this.faction = faction;
            this.abilityPoints = abilityPoints;
            this.healthPoints = healthPoints;
            this.level = level;

        }


        //METHODS
        public void Greetings(String name)
        {
            Console.WriteLine("I am " + this.name + ", Hello " + name + " nice to meet you");
            // example of using this with
            // parameter and field using same word
        }
        public void HolyBow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
