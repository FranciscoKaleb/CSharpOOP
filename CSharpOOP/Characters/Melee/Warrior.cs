using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Enumerations;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.ArmorTypes.Heavy;
using CSharpOOP.Equipment.WeaponTypes.Sharp;
using CSharpOOP.Characters;

namespace CSharpOOP.Characters.Melee
{
    public class Warrior : Character
    {
        //CONSTANTS or DEFAULT VALUES
        private const int WARRIOR_BONUS_HEALTH = 100;


        // FIELDS
        private Axe weapon;
        private Chainlink armor;
        

        // PROPERTIES   
        public Axe Weapon 
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = new Axe();
            }
        }
        public Chainlink Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        

        // CONSTRUCTORS
        public Warrior()
        {

        }
        public Warrior(string name, int age, int height, int weight, Faction faction)
            : base(name,age,height,weight,faction)
        {
            HealthPoints = HealthPoints + WARRIOR_BONUS_HEALTH + FactionBonusHealth;
            Weapon = new Axe();
        }
        

        // METHODS
        public void Greetings(String name)
        {
            Console.WriteLine("I am " + this.Name + ", Hello " + name + " nice to meet you");
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
                $"Name: {warrior.Name}\n" +
                $"Age: {warrior.Age}\n" +
                $"Weight: {warrior.Weight}\n" +
                $"Height: {warrior.Height}\n" +
                $"Faction: {warrior.Faction}\n" +
                $"Health Points: {warrior.HealthPoints}\n" +
                $"Damage: {warrior.Weapon.Damage}\n" +
                $"Experience Points: {warrior.ExperiencePoints}");
        }
        
    }
}
