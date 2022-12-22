using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment
{
    public class Equipments
    {
        private const int DEFAULT_WEIGHT = 1;

        private int damage;
        private int weight;
        
        public int Weight 
        { 
            get 
            { 
                return weight; 
            } 
            set 
            { 
                weight = value; 
            } 
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        public Equipments()
        {
            Weight = DEFAULT_WEIGHT;
            Damage = 0;
        }
        
    }
}
