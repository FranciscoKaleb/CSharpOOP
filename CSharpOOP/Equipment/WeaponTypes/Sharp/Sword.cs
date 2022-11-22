using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage { get; set; }

        public Sword()
        {

        }

        public void BloodThirst()
        {
            Console.WriteLine("BloodThirst!");
            damage = 80;
        }
    }
}
