using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.weapons;

namespace mandatory_assignment.Weapons
{
    public class Fists : BaseWeapon
    {
        public override string Name
        {
            get { return "Fists"; }
        }
        public override int damage
        {
            get { return 0; }
        }
    }
}
