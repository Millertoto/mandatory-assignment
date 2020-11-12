using System;
using mandatory_assignment;

namespace Test_zone
{
    class Program
    {
        static void Main(string[] args)
        {
            World TestWorld = new World();
            Player johnPlayer = new Player("John", 20, 2, 2,2);
            TestWorld.FindWeapon(johnPlayer);
            TestWorld.FindEnemy(johnPlayer);
            johnPlayer.status();
            johnPlayer.GainExperience(10);
            TestWorld.FindWeapon(johnPlayer);
            johnPlayer.status();
            johnPlayer.GainExperience(4);
            johnPlayer.status();
            johnPlayer.GainExperience(20);
            TestWorld.FindWeapon(johnPlayer);
            johnPlayer.status();
        }
    }
}
