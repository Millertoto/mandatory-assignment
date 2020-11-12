using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.Interfaces
{
    public interface IEnemy
    {
        string Name { get; }
        int Damage { get; }
        int Experience { get; }
        int HitPoints { get; }

        bool Dead { get; }

        int DealDamage();
        void ReceiveDamage(int value);

    }
}
