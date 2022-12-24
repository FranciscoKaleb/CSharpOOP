using CSharpOOP.Abilities;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment;
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
        // fields
        private Ability ability;
        private OmniSlash omniSlash;

        // properties
        public OmniSlash OmniSlash
        {
            get
            {
                return omniSlash;
            }
            set
            {
                omniSlash = value;
            }
        }
        public Blade Blade 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        // constructors
        public Kenshin()
        {
            OmniSlash = new OmniSlash();
        }

        // methods
        public override void SkillCast(Unit target, Ability OmniSlash)
        {
            target.HealthPoints = target.HealthPoints - (this.AbilitySlot.Ability[0].Damage);
        }
        public override void PickUpItem(Equipm equipment)
        {
            //Inventory.Item[slot] = equipment;
            BaseDamage = BaseDamage + equipment.Damage;

        }
        public override void Attack(Unit unit,bool start)
        {
            unit.HealthPoints = unit.HealthPoints - BaseDamage;
        }
        public override void Attack2(Hero target)
        {
            target.isAttacked(ApplyCritical(this.BaseDamage),this);
        }
        public int ApplyCritical(int damage)
        {
            double criticalChance = 0.1;
            Random random = new Random();
            Boolean isCritical = random.NextDouble() < criticalChance;

            if (isCritical)
            {
                damage = damage * 3;
            }
            else
            {
                damage = damage;
            }
            return damage;
        }
        public override void Move(int pauseBetweenMove)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(pauseBetweenMove);
                Console.WriteLine($"I am {Name}, moving forward!\n");
            }
        }
        public override void Stop(Unit unit)
        {

        }
        public override void getAbility(Ability ability, int slot)
        {
            AbilitySlot.Ability[slot] = ability;
        }
        public override void Greetings()
        {
            Console.WriteLine("Hello I am Kenshin\n");
        }
        public override void gainExp(Hero killed)
        {
            this.ExperiencePoints = this.ExperiencePoints + (killed.Level * 500);

        }
        public override void isAttacked(int totalDamage, Hero attacker)
        {

        }



    }
}
