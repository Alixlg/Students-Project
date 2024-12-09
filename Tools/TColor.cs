using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Tools
{
    public class TColor
    {
        public static void Red(string c)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(c);
            Console.ResetColor();
        }
        public static void Blue(string c)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(c);
            Console.ResetColor();
        }
        public static void White(string c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(c);
            Console.ResetColor();
        }
        public static void Yellow(string c)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(c);
            Console.ResetColor();
        }
        public static void Green(string c)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(c);
            Console.ResetColor();
        }
        public static void Cyan(string c)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(c);
            Console.ResetColor();
        }
    }
}