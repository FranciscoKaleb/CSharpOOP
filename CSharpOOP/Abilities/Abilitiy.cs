using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abilities
{
    public class Ability
    {
        private int manaCost;
        public int ManaCost
        {
            get { return manaCost; }
            set { manaCost = value; }
        }

        public Ability()
        {

        }

    }
}
