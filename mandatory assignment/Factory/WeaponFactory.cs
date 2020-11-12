using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Interfaces;
using mandatory_assignment.weapons;

namespace mandatory_assignment.Factory
{
    public class WeaponFactory : IWeaponFactory

    {
        public IWeapon Create(int value)
        {
            var random = new Random();
            IWeapon Weapon = null;
            if (value == 1)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new Dagger();
                        break;
                    case 2:
                        Weapon = new Flail();
                        break;
                    case 3:
                        Weapon = new Warhammer();
                        break;
                }
            }


            else if (value == 2)
            {

                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new Flail();
                        break;
                    case 2:
                        Weapon = new Warhammer();
                        break;
                    case 3:
                        Weapon = new Sword();
                        break;
                }
            }

            else if (value == 3)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new Warhammer();
                        break;
                    case 2:
                        Weapon = new Sword();
                        break;
                    case 3:
                        Weapon = new EnchantedDagger();
                        break;
                }

            }

            else if (value == 4)
            {


                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new Sword();
                        break;
                    case 2:
                        Weapon = new EnchantedDagger();
                        break;
                    case 3:
                        Weapon = new EnchantedFlail();
                        break;
                }
            }

            else if (value == 5)
            {

                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new EnchantedDagger();
                        break;
                    case 2:
                        Weapon = new EnchantedFlail();
                        break;
                    case 3:
                        Weapon = new EnchantedWarhammer();
                        break;
                }
            }

            else if (value > 5)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        Weapon = new EnchantedFlail();
                        break;
                    case 2:
                        Weapon = new EnchantedWarhammer();
                        break;
                    case 3:
                        Weapon = new EnchantedSword();
                        break;
                }
            }
            return Weapon;
        }
    }
}

