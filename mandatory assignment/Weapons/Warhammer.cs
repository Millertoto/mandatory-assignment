using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.weapons
{
    public class Warhammer : BaseWeapon
    {
        public override string Name
        {
            get { return "Warhammer"; }
        }
        public override int damage
        {
            get { return 6; }
        }
    }
}
