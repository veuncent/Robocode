using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;


namespace Veuncent
{
    public class Skirmisher : Robot
    {
        public override void Run()
        {
            while (true)
            {
                Ahead(20);
                TurnRight(60);
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(3);
            TurnLeft(45);
            Back(80);
        }

        public override void OnHitWall(HitWallEvent e)
        {
            Ahead(120);
            TurnLeft(100);
            Ahead(100);
            TurnLeft(10);
        }
    }
}
