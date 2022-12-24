using CSharpOOP.Units.Movable.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.ArmorTypes.Heavy
{
    public class Chainlink : Equipm
    {     
        public Chainlink()
        {
            Armor = 15;
            Name = "ChainLink";
            Description = "Adds 15 Armor";
        }
        public override void IsPickedUp(Hero picker)
        {
            picker.ArmorPoints = picker.ArmorPoints + this.Armor;   
        }
    }
}
