using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.Interfaces
{
    public interface IEnemyFactory
    {
        IEnemy Create(int value);
    }
}
