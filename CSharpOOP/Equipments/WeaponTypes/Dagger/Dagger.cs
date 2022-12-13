using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Dagger
{
    public class Dagger
    {
        private int damage;

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
                    throw new ArgumentOutOfRangeException(string.Empty, "damage must greater or equal 1");
                }
            }
        }

        public Dagger()
        {

        }

        public void Poison()
        {

        }
    }
}
