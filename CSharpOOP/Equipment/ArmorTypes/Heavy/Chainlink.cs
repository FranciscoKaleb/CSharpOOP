using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment.ArmorTypes.Heavy
{
    public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints 
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty,"Armor points must be greater of equal to 1");
                }
            }
        }

        public Chainlink()
        {
           
        }

    }
}
