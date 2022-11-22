using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.Melee
{
    internal class Warrior
    {
        private int height; // this part of the class is called a FIELD. only used inside a class
        private int weight;
        private string name;

        public int Height { get; set; } // this part is called a PROPERTY. can be used outside the class
        public int Weight { get; set; }
        public string Name { get; set; }

        public Warrior() // this part of the class is called a constructor //
        {

        }

        public Warrior(string name, int height, int weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        // this part is called the METHOD, the action of a class
        // inside the parenthesis we create an object of a class inside the class 
        public void greetings(Warrior nameObject)
        {
            Console.WriteLine("Hello " + nameObject.Name + "");
        }
    }
}
