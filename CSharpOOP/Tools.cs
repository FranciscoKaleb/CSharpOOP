using CSharpOOP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public static class Tools // Static class can only have static members. e.g. Console is a static class
    {
        public static void colorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;    
            Console.WriteLine(text);
            Console.ResetColor();
            // Console s = new Console();
            // Console class cannot/ doesnt need an instance
        }

    }
}
