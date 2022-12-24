using CSharpOOP.Abilities;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.WeaponTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable.Hero
{
    public abstract class Hero : Movable
    {
       
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_SKILL_POINTS = 1;
        private const int DEFAULT_STRENGTH = 10;
        private const int DEFAULT_AGILITY = 10;
        private const int DEFAULT_INTELLIGENCE = 10;
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_BASE_DAMAGE = 10;
        private const int DEFAULT_ATTACK_SPEED = 1000;
        private const int DEFAULT_EXPERIENCE_POINTS = 0;

        private int experiencePoints;
        private int level;
        private int baseDamage;
        private int attackSpeed;
        private int skillPoints;
        private int strength;
        private int agility;
        private int intelligence;
        private int manaPoints;
        private bool isAlive;
        private ItemInventory inventory;
        private AbilitySlot abilitySlot;

        public int ExperiencePoints
        {
            get
            {
                return this.experiencePoints;
            }
            set
            {
                this.experiencePoints = value;
            }
        }
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
        public int BaseDamage
        {
            get
            {
                return baseDamage;
            }
            set
            {
                baseDamage = value;
            }
        }
        public int AttackSpeed
        {
            get
            {
                return attackSpeed;
            }
            set
            {
                attackSpeed = value;
            }
        } //added
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
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public ItemInventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        public AbilitySlot AbilitySlot
        {
            get { return abilitySlot; } 
            set { abilitySlot = value; }
        }

        public Hero()
            :this(DEFAULT_LEVEL,DEFAULT_EXPERIENCE_POINTS, DEFAULT_SKILL_POINTS, DEFAULT_STRENGTH, DEFAULT_AGILITY
                 ,DEFAULT_INTELLIGENCE,DEFAULT_MANA_POINTS, DEFAULT_BASE_DAMAGE, DEFAULT_ATTACK_SPEED)
        {

        }
        public Hero(int level, int experiencePoints, int skillPoints, int strength, int agility,
            int intelligence, int manaPoints, int baseDamage, int attackSpeed)
        {
            Level = level;
            ExperiencePoints = experiencePoints;
            SkillPoints = skillPoints;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            ManaPoints = manaPoints;
            BaseDamage = baseDamage;
            AttackSpeed = attackSpeed;
            HealthPoints = 500;
            IsAlive = true;
            Inventory = new ItemInventory();
            AbilitySlot = new AbilitySlot();
        }

        public abstract void Attack2(Hero hero);
        public abstract void Attack(Unit unit,bool start);
        public abstract void PickUpItem(Equipm equipment);
        public abstract void SkillCast(Unit unit, Ability ability);
        public abstract void getAbility(Ability ability, int slot);
        public abstract void Greetings();
        public abstract void gainExp(Hero killed);
        public abstract void isAttacked(int totalDamage, Hero attacker);

        public static void SeeStatus(Hero hero)
        {
            Console.WriteLine($"name:{hero.Name}\n" +
                $"health:{hero.HealthPoints}\n" +
                $"Damage: {hero.BaseDamage}\n" +
                $"armor:{hero.ArmorPoints}\n" +
                $"armorType:{hero.ArmorType}\n" +
                $"movement speed: {hero.MovementSpeed}\n" +
                $"movement type:{hero.MovementType}\n" +
                $"level: {hero.Level}\n" +
                $"skillPoints:{hero.SkillPoints}\n" +
                $"strength:{hero.Strength}\n" +
                $"agility:{hero.Agility}\n" +
                $"intelligence:{hero.Intelligence}\n" +
                $"mana: {hero.ManaPoints}\n"+
                $"Slot 1: {hero.Inventory.Item[0].Name}\n"+
                $"Slot 2: {hero.Inventory.Item[1].Name}\n" +
                $"Slot 3: {hero.Inventory.Item[2].Name}\n" +
                $"Slot 4: {hero.Inventory.Item[3].Name}\n" +
                $"Slot 5: {hero.Inventory.Item[4].Name}\n" +
                $"Slot 6: {hero.Inventory.Item[5].Name}\n");
        }

    }
}
