using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class Flail:BaseWeapon
    {
        public override string Name
        {
            get { return "Flail"; }
        }
        public override int damage
        {
            get { return 4; }
        }
    }
}
