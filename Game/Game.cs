using System;
using System.Collections.Generic;
using System.Text;
using MenuDrivenGame;

namespace MenuDrivenGame
{
    public static class Game
    {
        static bool Running = true;                                             // Static properties
        static bool Goal = false;
        private static int _currentLocation = 0;                                  // Always start at The Hub
        public static int Health = 5;

        public static int CurrentLocation 
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        public static void Play()                                               // Start the main loop
        {
            Start();
            while (Running)
            {
                Menu.ShowMenu();
            }
            End();
        }

        public static void Start()                                              // What happens when the game is started
        {
            Console.Clear();
            Console.WriteLine("Some introductory text..");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void End()                                                // What happens when the game ends
        {
            Console.WriteLine("Game Over. Press any key to exit.");
            Console.ReadKey();
        }       
        
        
        public static void HandleLevelInput(int choice)                         
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Welcome to the {Location.Name[_currentLocation]}.");
                    break;
                case 2:
                    _currentLocation = 1;
                    break;
                case 3:
                    Running = false;
                    break;
            }
        }

        public static void HandleCrossroadsInput(int choice)
        {
            switch (choice)
            {
                case 1:
                    _currentLocation = 2;
                    break;
                case 2:
                    _currentLocation = 3;
                    break;
                case 3:
                    _currentLocation = 4;
                    break;
                case 4:
                    _currentLocation = 5;
                    break;
                case 5:
                    _currentLocation = 0;
                    break;
                case 6:
                    Running = false;
                    break;
            }
        }

        public static void HandleHubInput(int choice)
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
                    _currentLocation = 1;
                    break;
                case 4:
                    Running = false;
                    break;
            }
        }
    }
}
