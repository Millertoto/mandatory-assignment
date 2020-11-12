
using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class Sword:BaseWeapon
    {
        public override string Name
        {
            get { return "Sword"; }
        }
        public override int damage
        {
            get { return 8; }
        }
    }
}
