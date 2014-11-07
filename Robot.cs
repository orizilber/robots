using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robots
{
    class Robot
    {
        private static int counter = 0;
        private string color;
        private int tile;
        private bool isInGame;
        private int id;


<<<<<<< HEAD
        public Robot()
        {
            this.color = "";
            this.tile = 10;
            this.isInGame = true;
            this.id = Robot.counter;
            Robot.counter++;
        }

        public Robot(string col, bool isI)
        {
            this.color = col;
            this.tile = 10;
            this.isInGame = isI;
            this.id = Robot.counter;
            Robot.counter++;
        }


        public string GetColor()
        {
            return this.color;
        }

        public int GetTile()
        {
            return this.tile;
        }

        public bool GetIsInGame()
        {
            return this.isInGame;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetColor(string col)
        {
            this.color = col;
        }

        public void SetTile(int til)
        {
            this.tile = til;
        }

        public void SetIsInGame(bool iig)
        {
            this.isInGame = iig;
        }

        public void oneStepF()
        {
            this.tile += 1;
        }

        public void oneStepB()
        {
            this.tile -= 1;
        }

        public void nStepF(int n)
        {
            this.tile += n;
        }

        public void nStepB(int n)
        {
            this.tile -= n;
        }

        public override string ToString()
        {
            return "Robot: color=" + this.color + ", tile=" + this.tile + ", isInGame=" + this.isInGame;
        }
    }
}




=======
    public Robot()
    {
        this.color = "";
        this.tile = 10;
        this.isInGame = true;
    }

    public Robot(int col, int til, int isI)
    {
        this.color = col;
        this.tile = til;
        this.isInGame = isI;
    }


    public string GetColor()
    {
        return this.color;
    }

    public int GetTile()
    {
        return this.tile;
    }

    public bool GetIsInGame()
    {
        return this.isInGame;
    }


    public void oneStepF()
    {
        this.tile += 1;
    }

    public void oneStepB()
    {
        this.tile -= 1;
    }

    public void nStepF(int n)
    {
        this.tile += n;
    }

    public void nStepF(int n)
    {
        this.tile -= n;
    }
}
>>>>>>> 92fa0efef1284626e03f713d09f16d0fe79afdb1
