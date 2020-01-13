using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public static class WeaponRarities
    {
        public static WeaponRarity Simple 
        { 
            get => new WeaponRarity() 
            { 
                Name = "Simple",
                TextColour = "White",
                DamageMultiplier = 1d,
            }; 
        }

        public static WeaponRarity Quality
        {
            get => new WeaponRarity()
            {
                Name = "Quality",
                TextColour = "Yellow",
                DamageMultiplier = 1.5d,
            };
        }

        public static WeaponRarity Rare
        {
            get => new WeaponRarity()
            {
                Name = "Rare",
                TextColour = "Green",
                DamageMultiplier = 3d,
            };
        }

        public static WeaponRarity Legendary
        {
            get => new WeaponRarity()
            {
                Name = "Legendary",
                TextColour = "Blue",
                DamageMultiplier = 7d,
            };
        }

        public static WeaponRarity Ancient
        {
            get => new WeaponRarity()
            {
                Name = "Ancient",
                TextColour = "Red",
                DamageMultiplier = 15d,
            };
        }
    }
}
