using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public class Sword_Initial
    {
        private string Name;
        private int RarityIndex;
        private string[] Rarity = { "Simple", "Quality", "Rare", "Legendary", "Otherwordly" };
        private string[] RarityTextColour = { "White", "Yellow", "Green", "Blue", "Red" };
        private int BaseDamage = 1;
        private double[] DamageMultiplier = { 1d, 1.5d, 3d, 6d, 15d };
        private double TotalDamage;
        private int DropRateModifier = 100;

        public Sword_Initial()
        {
            Random random = new Random();
            int randomNumber = random.Next(DropRateModifier);
            if (randomNumber >= 99)
            {
                RarityIndex = 4;
            }
            else if (randomNumber >= 95)
            {
                RarityIndex = 3;
            }
            else if (randomNumber >= 80)
            {
                RarityIndex = 2;
            }
            else if (randomNumber >= 50)
            {
                RarityIndex = 1;
            }
            else
            {
                RarityIndex = 0;
            }
            TotalDamage = BaseDamage * DamageMultiplier[RarityIndex];
            Name = $"{Rarity[RarityIndex]} Sword";
            Console.Write("You've found a ");
            Utility.ColourText(Name, RarityTextColour[RarityIndex]);
            Console.WriteLine(" Sword!");
        }
    }
}
