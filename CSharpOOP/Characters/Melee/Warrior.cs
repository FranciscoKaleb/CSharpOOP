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
        //CONSTANTS
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 60;
        private const string DEFAULT_NAME = "Young Warrior";
        private const string DEFAULT_FACTION = "melee";
        private const int DEFAULT_AGE = 18;
        private const int DEFAULT_STAT = 10;
        private const int DEFAULT_STARTING_HEALTH = 100;
        private const int DEFAULT_STARTING_LEVEL = 1;
        private readonly Axe DEFAULT_AXE_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_ARMOR_WEAPON = new Chainlink();

        //NON-CONSTANT VARIABLES
        private static int DEFAULT_STARTING_COUNTER = 1;

        // FIELDS
        private static int idCounter; // not a field?
        private readonly int id;        
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
        public static int IdCounter
        {
            get
            {
                return Warrior.idCounter;
            }
            private set
            {
                Warrior.idCounter = DEFAULT_STARTING_COUNTER;
                DEFAULT_STARTING_COUNTER++;
            }
        } // not a property?
        public int Id
        {
            get
            {
                return this.id;
            }
        }    
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
            : this(DEFAULT_NAME)
        {

        }
        public Warrior(string name)
            : this(name, DEFAULT_AGE)
        {

        }
        public Warrior(string name, int age)
            : this(name, age, DEFAULT_HEIGHT)
        {

        }
        public Warrior(string name, int age, int height)
            : this(name, age, height, DEFAULT_WEIGHT)
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
            : this(name, age, height, weight, weapon, armor, DEFAULT_FACTION)
        {

        }
        public Warrior(string name, int age, int height, int weight, Axe weapon, Chainlink armor, string faction)
            : this(name, age, height, weight, weapon, armor, faction, DEFAULT_STAT)
        {
            
        }
        public Warrior(string name, int age, int height, int weight, Axe weapon, Chainlink armor, string faction, int abilityPoints)
            : this(name, age, height, weight, weapon, armor, faction, abilityPoints, DEFAULT_STARTING_HEALTH)
        {
            
        }
        public Warrior(string name, int age, int height, int weight, Axe weapon, Chainlink armor, string faction, int abilityPoints, int healthPoints)
            : this(name, age, height, weight, weapon, armor, faction, abilityPoints, healthPoints, DEFAULT_STARTING_LEVEL)
        {
            
        }
        public Warrior(string name, int age, int height, int weight, Axe weapon, Chainlink armor, string faction, int abilityPoints, int healthPoints, int level)
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
            Warrior.IdCounter++;
            this.id = IdCounter;
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
        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"Default Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault weight: {DEFAULT_WEIGHT}"+
                $"\nDefault Height: {DEFAULT_HEIGHT}"+
                $"\nDefault Sword Damage:{warrior.DEFAULT_AXE_WEAPON.Damage}"
                );
        }
    }
}
