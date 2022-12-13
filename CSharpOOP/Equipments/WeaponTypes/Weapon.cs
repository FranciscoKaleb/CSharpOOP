using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes
{
    public class Weapon : Equipments
    {
        private const int DEFAULT_DAMAGE = 10;

        private int damage;

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

        public Weapon()
        {
            Damage = DEFAULT_DAMAGE;
        }
    }
}
