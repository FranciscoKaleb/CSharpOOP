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

            Assassin assassin = new Assassin();
            assassin.Name = "Marcus";
            assassin.Greetings("kaleb");

            

        }
    }
}