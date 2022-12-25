using CSharpOOP.Abilities;
using CSharpOOP.Abilities.Hero;
using CSharpOOP.Equipment.WeaponTypes.Blade;
using CSharpOOP.Interfaces;
using CSharpOOP.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Equipment.WeaponTypes;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Abilities.Hero.Samurai;

namespace CSharpOOP.Units.Movable.Hero.Samurai
{
    public class Samurai : Hero , ISamurai
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
        public Blade Blade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        // constructors
        public Samurai()
        {
            OmniSlash = new OmniSlash();
        }

        // methods
        public override void SkillCast(Unit target, Ability OmniSlash)
        {
            target.HealthPoints = target.HealthPoints - (AbilitySlot.Ability[0].Damage);
        }       
        public override void PickUpItem(Equipm equipment)
        {
            //loop through inventory to chose a slot 0,1,2,3,4,5
            for (int slot = 0; slot < 6; slot++)
            {
                if(this.Inventory.Item[slot].Name == "empty")
                {
                    this.Inventory.Item[slot] = equipment;
                    equipment.IsPickedUp(this);
                    break;
                }
                else
                {
                    Console.WriteLine("Inventory is full");
                }
            }                       
        }
        public override void Attack(Unit unit, bool start)
        {
            BaseDamage = BaseDamage - unit.ArmorPoints;
            while (start == true)
            {
                Thread.Sleep(this.AttackSpeed);
                unit.HealthPoints = ((unit.HealthPoints) - BaseDamage);
                Console.WriteLine($"{unit.HealthPoints}");
                if (unit.HealthPoints <= 0)
                {
                    start = false;
                    Console.WriteLine($"{unit.Name} is dead");
                    unit.IsAlive = false;
                    gainExp((Hero)unit);
                }            
            }  
        }//bad approach
        public override void Attack2(Hero target)
        {
            target.isAttacked(ApplyCritical(this.BaseDamage),this);
        }   //a bit better approach
        public override void isAttacked(int totalDamage, Hero attacker)
        {
            totalDamage = totalDamage - this.ArmorPoints;
            this.HealthPoints = this.HealthPoints - totalDamage;
            //if(attacker has Equipment.Frost)
            //{this.MovementSpeed = this.MovementSpeed - %%}
            //DamageReduction()
        }
        public int ApplyCritical(int damage)
        {
            double criticalChance = 0.4;
            Random random = new Random();
            Boolean isCritical = random.NextDouble() <= criticalChance;

            if (isCritical)
            {
                damage = damage * 3;
                Console.WriteLine("Critical");
            }
            else
            {
                damage = damage;
            }
            return damage;
        }
        public override void gainExp(Hero killed)
        {
            this.ExperiencePoints = this.ExperiencePoints + (killed.Level * 500);

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
            Console.WriteLine("Hello I am Samurai\n");
        }
        

        // static method/s
        public static void SeeStatus(Samurai hero)
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
                $"mana: {hero.ManaPoints}\n");
                //$"Slot 1: {hero.Inventory.Item[0].ToString()}\n" +
                //$"Slot 2: {hero.Inventory.Item[1].ToString()}\n" +
                //$"Slot 3: {hero.Inventory.Item[2].ToString()}\n" +
                //$"Slot 4: {hero.Inventory.Item[3].ToString()}\n" +
                //$"Slot 5: {hero.Inventory.Item[4].ToString()}\n" +
                //$"Slot 6: {hero.Inventory.Item[5].ToString()}\n");
        }

        
    }
}
