using CSharpOOP.Equipment.ArmorTypes.Light;
using CSharpOOP.Equipment.WeaponTypes.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.SpellCasters
{
    internal class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe armor;
        private Stafff staff;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    abilityPoints = value;
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
                return healthPoints;
            }
            set
            {

                if (value >= 0)
                {
                    healthPoints = value;
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
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
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
                return faction;
            }
            set
            {
                if (value == "SpellCaster")
                {
                    faction = value;
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
                return name;
            }
            set
            {
                if (value.Length <= 20)
                {
                    name = value;
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
        public Stafff Staff 
        {
            get
            {
                return staff;
            }
            set
            {
                staff = value;
            }
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void FireWall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
