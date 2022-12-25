using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abilities.Hero.Samurai
{
    public class OmniSlash : Ability
    {
        private int damage;

        public override int Damage
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
