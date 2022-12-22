using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Abilities;

namespace CSharpOOP.Abilities.Hero
{
    public class AbilitySlot
    {
        private Ability[] ability;

        public Ability[] Ability
        {
            get
            {
                return ability;
            }
            set
            {
                ability = value;
            }
        }

        public AbilitySlot()
        {
            ability = new Ability[6];
        }
    }
}
