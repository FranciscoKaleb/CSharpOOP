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
        // FIELDS
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;

        private string name;
        private int age;
        private int height;
        private int weight;

        private Axe weapon;
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
                if (value.Length < 20)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "name must only contain max of 20 characters");
                   // Console.WriteLine("name must only contain max of 20 characters");
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

        public Axe Weapon 
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

        // CONSTRUCTORS
        public Warrior()
            : this("Young Warrior")
        {

        }
        public Warrior(string name)
            : this(name, 18)
        {

        }
        public Warrior(string name, int age)
            : this(name, age, 170)
        {

        }
        public Warrior(string name, int age, int height)
            : this(name, age, height, 65)
        {

        }
        public Warrior(string name, int age, int height, int weight)
            : this(name, age, height, weight, new Axe())
        {

        }
        public Warrior(string name, int age, int height, int weight, Axe weapon)
            : this(name, age, height, weight, weapon, new Chainlink())
        {

        }
        public Warrior(string name, int age, int height, int weight, Axe weapon, Chainlink armor)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.weapon = weapon;
            this.Armor = armor;
        }

        // METHODS
        public void Greetings(String name)
        {
            Console.WriteLine("I am " + this.name + ", Hello " + name + " nice to meet you");
            // example of using this with
            // parameter and field using same word
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
