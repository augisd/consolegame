using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public class Location                                                   // Represents players current location and determines what menu options are available
    {                                                                       // 1 - Hub, 2 - Crossroads, 3 - Plains, 4 - Woods, 5 - Cemetary. 6 - Castle Ruins
        public static string[] Name = { 
            "The Hub",
            "Crossroads",
            "Plains",
            "Woods",
            "Cemetary",
            "Old Castle Ruins" 
        };

        public static string[] MenuOptions = { 
            "\t(1) Shop\t(2) Clinic\t(3) Travel\t(4) Exit Game",
            "\t(1) Plains\t(2) Woods\t(3) Cemetary\t(4) Old Castle Ruins\t(5) Go Back\t(6) Exit Game",
            "\t(1) Continue into the Plains\t(2) Go Back\t(3) Exit Game",
            "\t(1) Continue into the Woods\t(2) Go Back\t(3) Exit Game",
            "\t(1) Continue into the Cemetery\t(2) Go Back\t(3) Exit Game",
            "\t(1) Continue into the Castle Ruins\t(2) Go Back\t(3) Exit Game"
        };

        public static string[] Description =
        {
            "Welcome to The Hub. This is a safe zone where you can replenish your health and choose your next destination.",
            "Description of the location.",
            "Description of the location.",
            "Description of the location.",
            "Description of the location.",
            "Description of the location."
    };
    }
}
