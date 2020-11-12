using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Interfaces;

namespace mandatory_assignment.weapons
{
    public abstract class BaseWeapon : IWeapon
    {
        public abstract string Name { get; }
        public abstract int damage { get; }

        public override string ToString()
        {
            return $" you have found a {Name} that deals {damage} damage";
        }
    }
}
