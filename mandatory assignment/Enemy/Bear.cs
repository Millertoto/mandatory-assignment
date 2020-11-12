﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mandatory_assignment.Enemy
{
    public class Bear : baseEnemy
    {
        private int _hitPoints;

        public Bear(int hitPoints)
        {
            _hitPoints = hitPoints;
        }
        
        public override string Name
        {
            get { return "Bear"; }
        }

        public override int Damage
        {
            get { return 8; }
        }
        public override int Experience
        {
            get { return 4; }
        }
        public override int HitPoints
        {
            get { return _hitPoints; }
        }

        public override bool Dead => (HitPoints <= 0);

        public override int DealDamage()
        {
            Console.WriteLine($"{Name} Deals {Damage} points of damage");
            return Damage;
        }

        public override void ReceiveDamage(int value)
        {
            _hitPoints -= value;
            Console.WriteLine($"{Name} has {_hitPoints} HP");
        }
    }
}
