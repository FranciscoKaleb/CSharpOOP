﻿using CSharpOOP.Equipment.ArmorTypes.Light;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.SpellCasters
{
    internal class Druid
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe armor;

        public int AbilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public ClothRobe Armor { get; set; }

        public void MoonFire()
        {
            throw new NotImplementedException();
        }

        public void StarBurst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
