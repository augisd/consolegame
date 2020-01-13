using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public static class WeaponRarityRandomizer
    {
        static int _dropRatePossibilities = 100;
        static Random _random = new Random();
        static int _randomNumber;

        public static WeaponRarity GetRarity()
        {
            _randomNumber = _random.Next(_dropRatePossibilities);

            if (_randomNumber > 99)
            {
                return WeaponRarities.Ancient;
            }
            else if (_randomNumber >= 95)
            {
                return WeaponRarities.Legendary;
            }
            else if (_randomNumber >= 80)
            {
                return WeaponRarities.Rare;
            }
            else if (_randomNumber >= 50)
            {
                return WeaponRarities.Quality;
            }
            else
            {
                return WeaponRarities.Simple;
            }
        }
    }
}
