using CSharpOOP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units
{
    public abstract class Unit
    {
        public bool IsAlive = true;

        public const string DEFAULT_NAME = "Object";
        public const int DEFAULT_HEALTH_POINTS = 100;
        public const int DEFAULT_ARMOR_POINTS = 0;
        public const ArmorType DEFAULT_ARMOR_TYPE = ArmorType.Wood;

        private int id;
        private string name;
        private int healthPoints;
        private int armorPoints;
        private ArmorType armorType;

        public int Id
        {
            get 
            { 
                return this.id; 
            }
            set 
            { 
                this.id = value; 
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
        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                this.armorPoints = value;   
            }
        }
        public ArmorType ArmorType
        {
            get
            {
                return this.armorType;
            }
            set
            {
                this.armorType = value;
            }
        }

        public Unit()
            : this(DEFAULT_NAME, DEFAULT_HEALTH_POINTS, DEFAULT_ARMOR_POINTS, DEFAULT_ARMOR_TYPE)
        {

        }
        public Unit(string name, int healthPoints, int armorPoints, ArmorType armorType)
        {
            Name = name;
            HealthPoints = healthPoints;    
            ArmorPoints = armorPoints;
            ArmorType = armorType;
        }
        
      
    }
}
