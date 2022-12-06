using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Enumerations;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Equipment.WeaponTypes.Axe;

namespace CSharpOOP.Units.Zold
{
    public class Warrior : Unit
    {
        //CONSTANTS or DEFAULT VALUES
        private const int WARRIOR_BONUS_HEALTH = 100;


        // FIELDS
        private Axe weapon;
        private Chainlink armor;
        private int age;


        // PROPERTIES   
        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = new Axe();
            }
        }
        public Chainlink Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "must be 18 or get out");
                }
            }
        }


        // CONSTRUCTORS
        public Warrior()
            : base()
        {

        }
        public Warrior(string name, int age, int height, int weight, Faction faction)
            : base(name, age, height, weight, faction)
        {
            HealthPoints = HealthPoints + WARRIOR_BONUS_HEALTH + FactionBonusHealth;
            Weapon = new Axe();
        }


        // METHODS
        public void Greetings(string name)
        {
            Console.WriteLine("I am " + Name + ", Hello " + name + " nice to meet you");
            // example of using this with
            // parameter and field using same word
        }
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
        public static void GetWarriorInfo(Warrior warrior)
        {
            Console.WriteLine(
                $"Id: {warrior.Id}\n" +
                $"Name: {warrior.Name}\n" +
                $"Age: {warrior.Age}\n" +
                $"Weight: {warrior.Weight}\n" +
                $"Height: {warrior.Height}\n" +
                $"Faction: {warrior.Faction}\n" +
                $"Health Points: {warrior.HealthPoints}\n" +
                $"Damage: {warrior.Weapon.Damage}\n" +
                $"Experience Points: {warrior.ExperiencePoints}\n \n");
        }

        public override void Move(int pauseBetweenMove)
        {
            base.Move(pauseBetweenMove);
        }

    }
}
