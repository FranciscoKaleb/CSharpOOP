using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment;
using CSharpOOP.Units.Movable.Hero;

namespace CSharpOOP.Equipment.WeaponTypes.Axe
{
    public class Axe : Equipm
    {
        public Axe()
        {
            Damage = 50;
            Name = "Axe";
            Description = "This axe gives 50 damage";


        }
        public override void IsPickedUp(Hero picker)
        {
            picker.BaseDamage = picker.BaseDamage + this.Damage;
            picker.AttackSpeed = picker.AttackSpeed + this.AttackSpeed;
        }   
    }
}
