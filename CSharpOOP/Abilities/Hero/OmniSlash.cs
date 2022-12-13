using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abilities.Hero
{
    public class OmniSlash : Ability
    {
        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public OmniSlash()
        {
            Damage = 10;
        }
            

    }
}
