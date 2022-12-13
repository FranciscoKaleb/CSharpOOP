using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Axe
{
    public class Axe
    {
        private int damage;
        private int kills;
        private int killDamageBonus;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "damage must be greater or equal 1");
                }
            }
        }
        public int Kills
        {
            get
            {
                return kills;
            }
            set
            {
                kills = value;
            }
        }
        public int KillDamageBonus
        {
            get
            {
                return killDamageBonus;
            }
            set
            {
                killDamageBonus = value;
            }
        }

        public Axe()
        {
            Damage = 10;
        }

        public void HackAndSlash()
        {

        }
    }
}
