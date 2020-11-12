using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Factory;
using mandatory_assignment.Interfaces;

namespace mandatory_assignment
{
    public class World
    {
        
        public void FindWeapon(Player p)
        {
            var Weapon = new WeaponFactory().Create(p.Level);
            p.EquipWeapon(Weapon);
        }

        public void FindEnemy(Player p)
        {
            var Enemy = new EnemyFactory().Create(p.Level);
            while (!p.Dead && !Enemy.Dead)
            {
                Fight(p,Enemy);
            }

            if (Enemy.Dead)
            {
                p.GainExperience(Enemy.Experience);
            }
            else
            {
                p.Reset();
            }
        }

        public void Fight(Player p, IEnemy enemy)
        {
            var random = new Random();
            if (random.Next(1,100) >= 50)
            {
                enemy.ReceiveDamage(p.DealDamage());
                if (!enemy.Dead)
                {
                    p.ReceiveDamage(enemy.DealDamage());
                }
            }
            else
            {
                p.ReceiveDamage(enemy.DealDamage());
                if (!p.Dead)
                {
                    enemy.ReceiveDamage(p.DealDamage());
                }
            }
        }
    }
}
