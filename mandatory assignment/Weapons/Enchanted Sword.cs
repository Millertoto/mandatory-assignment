
using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class EnchantedSword : BaseWeapon
    {
        public override string Name
        {
            get { return "Enchanted Sword"; }
        }
        public override int damage
        {
            get { return 16; }
        }
    }
}
