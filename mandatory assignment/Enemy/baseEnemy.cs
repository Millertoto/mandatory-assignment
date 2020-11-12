using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Interfaces;

namespace mandatory_assignment.Enemy
{
    public abstract class baseEnemy: IEnemy
    {
        
        public abstract string Name { get; }
        public abstract int Damage { get; }
        public abstract int Experience { get; }
        public abstract int HitPoints { get; }
        public abstract bool Dead { get; }

        public abstract int DealDamage();
        public abstract void ReceiveDamage(int value);
    }
}
