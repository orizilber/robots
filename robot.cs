class Robot
{
    private string color;
    private int tile;
    private bool isInGame;


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
