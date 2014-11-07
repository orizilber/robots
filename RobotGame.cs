using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robots
{
    class RobotGame
    {
        private int numOfTiles;
        private Robot[] robots;
        private Robot[] robotsOnTiles;

        // טענת כניסה: הבנאי לא מקבל דבר
        // טענת יציאה: הבנאי לא מחזיר דבר
        public RobotGame()
        {
            this.numOfTiles = 0;
            this.robots = null;
            this.robotsOnTiles = null;
        }

        public RobotGame(int not, Robot[] robs)
        {
            this.numOfTiles = not;
            this.robots = robs;
            this.robotsOnTiles = new Robot[this.numOfTiles];
        }

        public int GetNumOfTiles()
        {
            return this.numOfTiles;
        }

        public Robot[] GetRobots()
        {
            return this.robots;
        }

        public void SetNumOfTiles(int not)
        {
            this.numOfTiles = not;
        }

        public void SetRobots(Robot[] robs)
        {
            this.robots = robs;
        }

        // טענת כניסה: הפונקציה לא מקבלת דבר
        // טענת יציאה: הפונקציה מחזירה את הרובוט הנמצא במקום המתקדם ביותר בלוח המשחק
        public Robot GetCurrentlyWinningRobot()
        {
            for (int i = this.numOfTiles-1; i >= 0 ; i--)
            {
                if (this.robotsOnTiles[i] != null && this.robotsOnTiles[i].GetIsInGame())
                {
                    return this.robotsOnTiles[i];
                }
            }
            return null;
        }

        //public bool IsSomeoneInGame()
        //{
        //    for (int i = 0; i < this.robots.Length; i++)
        //    {
        //        if (this.robots[i].GetIsInGame())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void PrintBoard()
        {
            Console.Write("|");
            for (int i = 0; i < this.robotsOnTiles.Length; i++)
            {
                if (this.robotsOnTiles[i] != null)
                {
                    Console.Write(this.robotsOnTiles[i].GetId());
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write("|");
            }
            Console.WriteLine("");
        }



        public void Play()
        {
            Random rnd = new Random();
            int randVal, oldRobotPos, newRobotPos;
            int roundCounter = 0;

            // Place the first robot to avoid thinking everyone has lost.
            this.robotsOnTiles[this.robots[0].GetTile()] = this.robots[0];

            while (this.GetCurrentlyWinningRobot() != null && this.GetCurrentlyWinningRobot().GetTile() != 100)
            {
                // First stage - place robots on board in their first round.
                for (int i = 0; i < this.robots.Length; i++)
                {
                    if (this.robots[i].GetIsInGame())  // Move only robots that are in game!
                    {
                        if (roundCounter == 0)
                        {
                            this.robotsOnTiles[this.robots[i].GetTile()] = this.robots[i];
                        }

                        // Get current robot's position on board.
                        oldRobotPos = this.robots[i].GetTile();

                        // decide which action to do on random.
                        randVal = rnd.Next(4);

                        // Do the action - move the robot.
                        switch (randVal)
                        {
                            case 0:
                                this.robots[i].oneStepF();
                                if (this.robots[i].GetTile() >= this.numOfTiles)
                                {
                                    this.robots[i].SetIsInGame(false);
                                }
                                break;
                            case 1:
                                this.robots[i].oneStepB();
                                if (this.robots[i].GetTile() < 0)
                                {
                                    this.robots[i].SetIsInGame(false);
                                }
                                break;
                            case 2:
                                this.robots[i].nStepF(rnd.Next(6) + 1);
                                if (this.robots[i].GetTile() >= this.numOfTiles)
                                {
                                    this.robots[i].SetIsInGame(false);
                                }
                                break;
                            case 3:
                                this.robots[i].nStepB(rnd.Next(6) + 1);
                                if (this.robots[i].GetTile() < 0)
                                {
                                    this.robots[i].SetIsInGame(false);
                                }
                                break;
                            default:
                                break;
                        }

                        if (this.robots[i].GetIsInGame())
                        {
                            // Eleminate robot that is already in the new position.
                            newRobotPos = this.robots[i].GetTile();
                            if (this.robotsOnTiles[newRobotPos] != null)
                            {
                                this.robotsOnTiles[newRobotPos].SetIsInGame(false);
                            }

                            // Move to the new position.
                            this.robotsOnTiles[newRobotPos] = this.robotsOnTiles[oldRobotPos];
                            this.robotsOnTiles[oldRobotPos] = null;
                        }
                    }
                }
                this.PrintBoard();
                roundCounter++;
            }
        }
    }
}