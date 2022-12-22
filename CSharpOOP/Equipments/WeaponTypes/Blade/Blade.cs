using CSharpOOP.Units.Movable.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.WeaponTypes.Blade
{
    public class Blade : Weapon
    {
        public Blade(Hero receiver)
        {
            Damage = 80;
            receiver.BaseDamage = receiver.BaseDamage + Damage;
        }
    }
}
