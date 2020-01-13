using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public static class HandleInput
    {
        public static void Level(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Welcome to the {Location.Name[Game.CurrentLocation]}.");
                    break;
                case 2:
                    Game.CurrentLocation = 1;
                    break;
                case 3:
                    Game.Running = false;
                    break;
            }
        }

        public static void Crossroads(int choice)
        {
            switch (choice)
            {
                case 1:
                    Game.CurrentLocation = 2;
                    break;
                case 2:
                    Game.CurrentLocation = 3;
                    break;
                case 3:
                    Game.CurrentLocation = 4;
                    break;
                case 4:
                    Game.CurrentLocation = 5;
                    break;
                case 5:
                    Game.CurrentLocation = 0;
                    break;
                case 6:
                    Game.Running = false;
                    break;
            }
        }

        public static void Hub(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Shop functionality to be implemented.");                    
                    break;
                case 2:
                    Console.WriteLine("Health replenished.");
                    break;
                case 3:
                    Game.CurrentLocation = 1;
                    break;
                case 4:
                    Game.Running = false;
                    break;
            }
        }
    }
}
