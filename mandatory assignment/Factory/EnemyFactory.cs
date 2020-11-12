using System;
using System.Collections.Generic;
using System.Text;
using mandatory_assignment.Enemy;
using mandatory_assignment.Interfaces;

namespace mandatory_assignment.Factory
{
    public class EnemyFactory : IEnemyFactory
    {
        public IEnemy Create(int value)
        {
            var random = new Random();
            IEnemy enemy = null;
            if (value == 1)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Wolf(20);
                        break;
                    case 2:
                        enemy = new Wolf(15);
                        break;
                    case 3:
                        enemy = new Wolf(25);
                        break;
                }
            }


            else if (value == 2)
            {

                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Wolf(20);
                        break;
                    case 2:
                        enemy = new Wolf(25);
                        break;
                    case 3:
                        enemy = new Bear(40);
                        break;
                }
            }

            else if (value == 3)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Wolf(25);
                        break;
                    case 2:
                        enemy = new Bear(40);
                        break;
                    case 3:
                        enemy = new Bear(40);
                        break;
                }

            }

            else if (value == 4)
            {


                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Bear(40);
                        break;
                    case 2:
                        enemy = new Bear(50);
                        break;
                    case 3:
                        enemy = new Bear(60);
                        break;
                }
            }

            else if (value == 5)
            {

                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Bear(50);
                        break;
                    case 2:
                        enemy = new Bear(60);
                        break;
                    case 3:
                        enemy = new Imp(70);
                        break;
                }
            }

            else if (value > 5)
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        enemy = new Bear(60);
                        break;
                    case 2:
                        enemy = new Imp(70);
                        break;
                    case 3:
                        enemy = new Imp(80);
                        break;
                }
            }
            return enemy;
        }
    }
}
