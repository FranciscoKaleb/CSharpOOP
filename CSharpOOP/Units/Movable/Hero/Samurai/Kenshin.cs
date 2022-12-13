using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using CSharpOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable.Hero.Samurai
{
    public class Kenshin : Hero, ISamurai
    {
        public Blade Blade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
        public void SkillCast(Unit unit, OmniSlash omniSlash)
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
