using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDrivenGame
{
    public static class WeaponTypes
    {
        public static WeaponType Melee 
        { 
            get => new WeaponType()
            {
                BaseDamage = 1,
                AttackRate = 1,
                Range = 1
            };
        }

        public static WeaponType Ranged 
        { 
            get => new WeaponType()
            {
                BaseDamage = 0.5,
                AttackRate = 0.5,
                Range = 2
            };
        }
    }
}
