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
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private Sword weapon;
        private Chainlink armor;


        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Faction { get; set; }
        public string Name { get; set; }
        public Sword Weapon { get; set; }
        public Chainlink Armor { get; set; }

        public Knight()
        {

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
