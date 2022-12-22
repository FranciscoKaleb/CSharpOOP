using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abilities
{
    public class Ability
    {
        private const int DEFAULT_MANACOST = 0;

        private int manaCost;
        private int damage;

        public int ManaCost
        {
            get { return manaCost; }
            set { manaCost = value; }
        }
        public virtual int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Ability()
        {
            ManaCost = DEFAULT_MANACOST;
        }

    }
}
