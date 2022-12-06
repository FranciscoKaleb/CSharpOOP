using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable.Hero
{
    public class Hero : Movable
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_SKILL_POINTS = 1;
        private const int DEFAULT_STRENGTH = 10;
        private const int DEFAULT_AGILITY = 10;
        private const int DEFAULT_INTELLIGENCE = 10;
        private const int DEFAULT_MANA_POINTS = 100;
        // private const Item > weapon, armor, artifact

        private int level;
        private int skillPoints;
        private int strength;
        private int agility;
        private int intelligence;
        private int manaPoints;

        public int Level 
        { 
            get 
            { 
                return this.level; 
            } 
            set 
            {
                this.level = value; 
            } 
        }   
        public int SkillPoints
        {
            get
            {
                return skillPoints;
            }
            set
            {
                skillPoints = value;
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }
        public int Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                this.agility = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                this.intelligence = value;
            }
        }
        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                this.manaPoints = value;
            }
        }

        public Hero()
            :this(DEFAULT_LEVEL, DEFAULT_SKILL_POINTS, DEFAULT_STRENGTH, DEFAULT_AGILITY
                 ,DEFAULT_INTELLIGENCE,DEFAULT_MANA_POINTS)
        {

        }
        public Hero(int level, int skillPoints, int strength, int agility,
            int intelligence, int manaPoints)
        {
            Level = level;
            SkillPoints = skillPoints;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            ManaPoints = manaPoints;
        }

       
    }
}
