using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public class Weapon
    {
        private readonly WeaponType _weaponType;
        private readonly WeaponRarity _weaponRarity;
        private readonly string _weaponName;

        public string Name { get => _weaponName; }
        public WeaponType Type { get => _weaponType; }
        public WeaponRarity Rarity { get; set; }

        public Weapon(WeaponType type, string name)
        {
            _weaponType = type;
            _weaponRarity = WeaponRarityRandomizer.GetRarity();
            _weaponName = $"{_weaponRarity.Name} {name} ";

            Console.Write("You've found a ");
            Utility.ColourText(_weaponName, _weaponRarity.TextColour);
        }
    }

    public class Sword : Weapon
    {
        public Sword(string name) : base(WeaponTypes.Melee, name)
        {

        }
    }

    public class Bow : Weapon
    {
        public Bow(string name) : base(WeaponTypes.Ranged, name)
        {

        }
    }
}
