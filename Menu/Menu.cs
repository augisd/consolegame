using System;
using System.Collections.Generic;
using System.Text;
using MenuDrivenGame;

namespace MenuDrivenGame
{
    public static class Menu
    {
        private static string _input;
        private static int _choice;
        public static void ShowMenu()                                               // Display options available to the player based on their current location
        {
            HUD.ShowHUD();
            Utility.RevealDescription(Location.Description[Game.CurrentLocation]);
            Console.WriteLine("...");
            Console.WriteLine("\tSelect one of the options below to continue.");
            Console.WriteLine(Location.MenuOptions[Game.CurrentLocation]);
            Console.Write(" >>> ");
            _input = Console.ReadLine();
            if (int.TryParse(_input, out _choice))
            {
                switch (Game.CurrentLocation)
                {
                    case 0:
                        HandleInput.Hub(_choice);
                        break;
                    case 1:
                        HandleInput.Crossroads(_choice);
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        HandleInput.Level(_choice);
                        break;
                }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                ShowMenu();
            }
        }
    }
}
