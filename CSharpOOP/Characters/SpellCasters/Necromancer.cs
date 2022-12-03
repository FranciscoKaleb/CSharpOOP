using CSharpOOP.Characters.Melee;
using CSharpOOP.Equipment.ArmorTypes.Light;
using CSharpOOP.Equipment.WeaponTypes.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Characters.Melee;

namespace CSharpOOP.Characters.SpellCasters
{
    public class Necromancer
    {
     
        // FIELDS
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private int age;
        private int height;
        private int weight;

        private string name;
        private string faction;

        private ClothRobe armor;
        private Stafff stafff;

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
                if(value >= 18)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "you must be 18 or above to create a character");
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
                return armor;
            }
            set
            {
                armor = value;
            } 
        }
        public Stafff Stafff 
        {
            get
            {
                return stafff;
            }
            set
            {
                stafff = value;
            } 
        }

        //CONSTRUCTORS
        public Necromancer()
            : this("Young Skull")
        {

        }
        public Necromancer(string name)
            : this(name, "Spell Caster")
        {

        }
        public Necromancer(string name, string faction)
            : this(name, faction, 18)
        {

        }
        public Necromancer(string name, string faction, int age)
            : this(name, faction, age, 170)
        {

        }
        public Necromancer(string name, string faction, int age, int height)
            : this(name, faction, age, height, 65)
        {

        }
        public Necromancer(string name, string faction, int age, int height, int weight)
            : this(name, faction, age, height, weight, new Stafff())
        {

        }
        public Necromancer(string name, string faction, int age, int height, int weight, Stafff weapon)
            : this(name, faction, age, height, weight, weapon, new ClothRobe())
        {

        }
        public Necromancer(string name, string faction, int age, int height, int weight, Stafff weapon, ClothRobe armor)
            : this(name, faction, age, height, weight, weapon, armor, 10)
        {
            
        }
        public Necromancer(string name, string faction, int age, int height, int weight, Stafff weapon, ClothRobe armor, int abilityPoints)
            : this(name, faction, age, height, weight, weapon, armor, abilityPoints, 100)
        {
            
        }
        public Necromancer(string name, string faction, int age, int height, int weight, Stafff weapon, ClothRobe armor, int abilityPoints, int healthPoints)
            : this(name, faction, age, height, weight, weapon, armor, abilityPoints, healthPoints, 1)
        {
            
        }
        public Necromancer(string name, string faction, int age, int height, int weight, Stafff weapon, ClothRobe armor, int abilityPoints, int healthPoints, int level)
        {
            this.name = name;
            this.faction = faction;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.stafff = weapon;
            this.armor = armor;
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
        public void ShadowRage()
        {
            throw new NotImplementedException();
        }
        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
        public void BoneShield()
        {
            throw new NotImplementedException();
        }
        
    }
}
