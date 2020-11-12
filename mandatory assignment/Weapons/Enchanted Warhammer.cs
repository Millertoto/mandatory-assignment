using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class EnchantedWarhammer : BaseWeapon
    {
        public override string Name
        {
            get { return "Enchanted Warhammer"; }
        }
        public override int damage
        {
            get { return 14; }
        }
    }
}
