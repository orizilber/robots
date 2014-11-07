using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot[] robots = new Robot[5] { new Robot("Blue", true),
                                            new Robot("Yellow-Black", true),
                                            new Robot("Lady-Pink", true),
                                            new Robot("Green", true),
                                            new Robot("Gray", true)};
            RobotGame game = new RobotGame(100, robots);
            game.Play();
        }
    }
}
