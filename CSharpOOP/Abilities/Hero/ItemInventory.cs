using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment;
using CSharpOOP.Equipments.WeaponTypes;

namespace CSharpOOP.Abilities.Hero
{
    public class ItemInventory
    {
        private Equipm[] item;

        public  Equipm[] Item
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
            Item = new Equipm[6];
            Item[0] = new ItemPlaceHolder();
            Item[1] = new ItemPlaceHolder();
            Item[2] = new ItemPlaceHolder();
            Item[3] = new ItemPlaceHolder();
            Item[4] = new ItemPlaceHolder();
            Item[5] = new ItemPlaceHolder();

        }
    }
}
