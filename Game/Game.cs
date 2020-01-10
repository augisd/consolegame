using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using MenuDrivenGame;

namespace MenuDrivenGame
{
    public static class Game
    {
        static bool _running = true;                                               // Static properties
        static bool Goal = false;
        private static int _currentLocation = 0;                                  // Always start at The Hub
        public static int Health = 5;

        public static int CurrentLocation 
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        public static bool Running
        {
            get { return _running; }
            set { _running = value; }
        }

        public static void Play()                                               // Start the main loop
        {
            Start();
            while (_running)
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
    }
}
