using System.Numerics;
using System;
using CSharpOOP.Characters.Melee;

namespace CSharpOOP
{
    public class EntryPoint
    {
        static void Main()
        {
            Warrior goodGuy = new Warrior("David", 165, 55); // this goodGuy is instance of class Warrior //
            // goodGuy.Height = 165;
            // goodGuy.Weight = 55;
            // goodGuy.Name = "David";

            Warrior badGuy = new Warrior();
            badGuy.Height = 180;
            badGuy.Weight = 67;
            badGuy.Name = "Saul";

            System.Console.WriteLine(badGuy.Height);

            goodGuy.greetings(badGuy); // calls the method greetings which outputs a console //
            badGuy.greetings(goodGuy);
        }
    }
}