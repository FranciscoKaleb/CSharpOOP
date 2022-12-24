using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment.WeaponTypes;
using CSharpOOP.Equipments;
using CSharpOOP.Units.Movable.Hero;

namespace CSharpOOP.Equipments.WeaponTypes
{
    public class ItemPlaceHolder : Weapon
    {
        public ItemPlaceHolder()
        {
            Name = "empty";
        }

        public override void IsPickedUp(Hero picker)
        {

        }
    }
}
