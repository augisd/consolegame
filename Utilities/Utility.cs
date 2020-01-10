using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrivenGame
{
    public class Utility
    {
        public static void ColourText(string text, string colour)
        {
            if (colour.ToLower() == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (colour.ToLower() == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (colour.ToLower() == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (colour.ToLower() == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (colour.ToLower() == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(text);
            Console.ResetColor();
        }

        public static void RevealDescription(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                Task.Delay(100).Wait();
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
    }
}
