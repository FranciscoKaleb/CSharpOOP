using CSharpOOP.Equipment.ArmorTypes.Light;
using CSharpOOP.Equipment.WeaponTypes.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.SpellCasters
{
    public class Druid
    {
        // FIELDS
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private int age;
        private int height;
        private int weight;

        private string faction;
        private string name;

        private ClothRobe armor;
        private Stafff staff;

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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty,"you must be 18 or above to create a character");
                }
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
                this.Height = value;
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

        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "SpellCaster")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Assassin faction should be SpellCaster");
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

        public ClothRobe Armor 
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
        public Stafff Staff 
        {
            get
            {
                return this.staff;
            }
            set
            {
                this.staff = value;
            }
        }

        //CONSTRUCTORS
        public Druid()
            : this ("Fairy")
        {

        }
        public Druid(string name)
            : this(name, "Spell Caster")
        {

        }
        public Druid(string name, string faction)
            : this(name, faction, 18)
        {

        }
        public Druid(string name, string faction, int age)
            : this(name, faction, age, 170)
        {

        }
        public Druid(string name, string faction, int age, int height)
            : this(name, faction, age, height, 60)
        {

        }
        public Druid(string name, string faction, int age, int height, int weight)
            : this(name, faction, age, height, weight, new ClothRobe())
        {

        }
        public Druid(string name, string faction, int age, int height, int weight, ClothRobe armor)
            : this(name, faction, age, height, weight, armor, new Stafff())
        {

        }
        public Druid(string name, string faction, int age, int height, int weight, ClothRobe armor, Stafff weapon)
            : this(name, faction, age, height, weight, armor, weapon, 10)
        {
            
             
        }
        public Druid(string name, string faction, int age, int height, int weight, ClothRobe armor, Stafff weapon, int abilityPoints)
            : this(name, faction, age, height, weight, armor, weapon, abilityPoints, 100)
        {
           

        }
        public Druid(string name, string faction, int age, int height, int weight, ClothRobe armor, Stafff weapon, int abilityPoints, int healthPoints)
            : this(name, faction, age, height, weight, armor, weapon, abilityPoints, healthPoints, 1)
        {
           

        }
        public Druid(string name, string faction, int age, int height, int weight, ClothRobe armor, Stafff weapon, int abilityPoints, int healthPoints, int level)
        {
            this.name = name;
            this.faction = faction;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.armor = armor;
            this.staff = weapon;
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
        public void MoonFire()
        {
            throw new NotImplementedException();
        }
        public void StarBurst()
        {
            throw new NotImplementedException();
        }
        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
