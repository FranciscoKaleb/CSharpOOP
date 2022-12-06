using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Equipment
{
    public class Equipment
    {
        private const int DEFAULT_WEIGHT = 1;

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

        public Equipment()
        {
            Weight = DEFAULT_WEIGHT;
        }
        
    }
}
