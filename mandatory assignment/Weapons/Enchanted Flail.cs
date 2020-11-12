using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class EnchantedFlail:BaseWeapon
    {
        public override string Name
        {
            get { return "Enchanted Flail"; }
        }
        public override int damage
        {
            get { return 12; }
        }
    }
}
