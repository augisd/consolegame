using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public static class HUD
    {
        public static void ShowHUD()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.Write("\tCurrent Location: ");
            Utility.ColourText(Location.Name[Game.CurrentLocation], "yellow");
            Console.Write("\tHealth: ");
            for (int i = 0; i < Game.Health; i++)
            {
                Utility.ColourText("+", "red");
            }
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
