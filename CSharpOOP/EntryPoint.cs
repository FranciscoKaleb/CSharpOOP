using System.Numerics;
using System;
using CSharpOOP.Characters.Melee;
using System.Security.Cryptography.X509Certificates;
using CSharpOOP.Equipment;
using CSharpOOP.Equipment.WeaponTypes.Sharp;

namespace CSharpOOP
{
    public class EntryPoint
    {
        
        static void Main()
        {

           Warrior warrior = new Warrior();
           Warrior warrior1 = new Warrior("David");
           Warrior warrior2 = new Warrior("Tony", 25);
           
            Console.WriteLine(""+warrior.Name+"\n" +
                ""+warrior.Age+"\n" +
                ""+warrior.Height+"\n" +
                ""+warrior.Weight+"\n" +
                ""+warrior.Weapon+"\n\n");
            Console.WriteLine("" + warrior1.Name + "\n" +
                "" + warrior1.Age + "\n" +
                "" + warrior1.Height + "\n" +
                "" + warrior1.Weight + "\n" +
                "" + warrior1.Weapon + "\n\n");
            Console.WriteLine("" + warrior2.Name + "\n" +
                "" + warrior2.Age + "\n" +
                "" + warrior2.Height + "\n" +
                "" + warrior2.Weight + "\n" +
                "" + warrior2.Weapon + "\n\n");
        }
    }
}