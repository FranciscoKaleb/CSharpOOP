using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Sharp
{
    public class Axe
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
                    throw new ArgumentOutOfRangeException(String.Empty,"damage must be greater or equal 1");
                }
            }
        }

        public Axe()
        {

        }

        public void HackAndSlash()
        {

        }
    }
}
