using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment;

namespace CSharpOOP.Abilities.Hero
{
    public class ItemInventory
    {
        private Equipments[] item;

        public Equipments[] Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public ItemInventory()
        {
            item = new Equipments[6];

        }
    }
}
