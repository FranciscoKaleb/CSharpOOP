using CSharpOOP.Units.Movable.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment
{
    public abstract class Equipm
    {
        private const int DEFAULT_WEIGHT = 1;
        private const string DEFAULT_NAME = "item";
        private const string DEFAULT_DESCRIPTION = "item description";
        private const int DEFAULT_DAMAGE = 0;
        private const int DEFAULT_ARMOR = 0;
        private const int DEFAULT_MOVEMENT_SPEED = 0;
        private const int DEFAULT_HEALTHPOINTS = 0;
        private const int DEFAULT_MANAPOINTS = 0;
        private const int DEFAULT_ATTACK_SPEED = 0;
        
        private int weight;
        private string name;
        private string description;
        private int damage;
        private int armor;
        private int movementSpeed;
        private int healthPoints;
        private int manaPoints;
        private int attackSpeed;

        public int Weight 
        { 
            get 
            { 
                return weight; 
            } 
            set 
            { 
                weight = value; 
            } 
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
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
                this.name = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;   
            }
        }
        public int Armor
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
        public int MovementSpeed
        {
            get
            {
                return this.movementSpeed;
            }
            set
            {
                this.movementSpeed = value;
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
                this.healthPoints = value;
            }
        }
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                this.manaPoints = value;
            }
        }
        public int AttackSpeed
        {
            get
            {
                return this.attackSpeed;
            }
            set
            {
                this.attackSpeed = value;
            }
        }

        public Equipm()
        {
            Weight = DEFAULT_WEIGHT;
            Damage = DEFAULT_DAMAGE;
            Name = DEFAULT_NAME;
            Description = DEFAULT_DESCRIPTION;
            Armor = DEFAULT_ARMOR;
            HealthPoints = DEFAULT_HEALTHPOINTS;
            MovementSpeed = DEFAULT_MOVEMENT_SPEED;
            ManaPoints = DEFAULT_MANAPOINTS;
            AttackSpeed = DEFAULT_ATTACK_SPEED;
        }

        public abstract void IsPickedUp(Hero picker);
        
    }
}
