using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
     public class EnchantedDagger : BaseWeapon
    {
        public override string Name
        {
            get { return "Enchanted Dagger"; }
        }
        public override int damage
        {
            get { return 10; }
        }
    }
}
