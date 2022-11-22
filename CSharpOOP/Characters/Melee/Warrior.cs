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
        

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Faction { get; set; }
        public string Name { get; set; }
        public Axe Weapon { get; set; }
        public Chainlink Armor{ get; set; }    

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
