using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
     public class Dagger : BaseWeapon
    {
        public override string Name
        {
            get { return "Dagger"; }
        }
        public override int damage
        {
            get { return 2; }
        }
    }
}
