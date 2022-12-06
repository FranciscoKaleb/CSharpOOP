using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Sharp.Sword
{
    public class Sword
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
                    throw new ArgumentOutOfRangeException(string.Empty, "damage must be greater or equal 1");
                }
            }
        }

        public Sword()
        {
            Damage = 10;
        }

        public void BloodThirst()
        {
            Console.WriteLine("BloodThirst!");
            damage = 80;
        }
    }
}
