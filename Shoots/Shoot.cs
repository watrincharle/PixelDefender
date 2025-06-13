
using Raylib_cs;

public class Shoot
{
    public int posX;
    public int posY;
    public int damage;
    public int orientation;
    public int speed;
    public bool isAlive;
    public Shoot(int pPosX, int pPosY, int pOrientation)
    {
        isAlive = true;
        this.posX = pPosX;
        this.posY = pPosY;
        this.orientation = pOrientation;
        this.damage = 1;
        this.speed = 10;
    }

    public void Update()
    {
        posY += speed * orientation;
        OutOfBounds();
    }

    private void OutOfBounds()
    {
        if (posX < 0 || posX > Raylib.GetScreenWidth() || posY < 0 || posY > Raylib.GetScreenHeight())
        {
            isAlive = false;
        }
    }
}