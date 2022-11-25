using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Blunt
{
    public class Hammer
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
                if(value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty,"damage should be equal or greater than 1");
                }
                
            } 
        }

        public void Stun()
        {

        }
    }
}
