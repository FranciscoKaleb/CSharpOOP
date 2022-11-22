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
                abilityPoints = value;
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
                healthPoints = value; 
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
                level = value;
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
               faction = value;
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
                name = value; 
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
