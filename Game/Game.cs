using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using MenuDrivenGame;

namespace MenuDrivenGame
{
    public static class Game
    {
        private static bool _running = true;                                              
        private static int _currentLocation = 0;                                  
        private static int _health = 5;

        public static int CurrentLocation 
        {
            get => _currentLocation;
            set => _currentLocation = value;
        }

        public static bool Running
        {
            get => _running;
            set => _running = value;
        }

        public static int Health
        {
            get => _health;
            set => _health = value;
        }

        public static void Play()                                               
        {
            Start();
            while (_running)
            {
                Menu.ShowMenu();
            }
            End();
        }

        public static void Start()                                              
        {
            Console.Clear();
            Console.WriteLine("Some introductory text..");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void End()                                                
        {
            Console.WriteLine("Game Over. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
