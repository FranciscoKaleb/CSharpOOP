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
        public Blade()
        {
            Damage = 80;
            Name = "Blade";
            Description = "This blade provides 80 Damage and 30 attackspeed";
            AttackSpeed = 30;
        }
        public override void IsPickedUp(Hero picker)
        {
            picker.BaseDamage = picker.BaseDamage + this.Damage;
            picker.AttackSpeed = picker.AttackSpeed + this.AttackSpeed;
        }
    }
}
