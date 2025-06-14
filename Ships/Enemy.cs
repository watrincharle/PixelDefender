

using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;

public class Enemy
{
    public Texture2D sprite;
    public int life;
    public bool isAlive;
    public int posX;
    public int posY;
    protected double timer;
    protected double timerInstance = 0;
    public bool isShooting;

    public Enemy(int pPosX, int pPosY, int life)
    {
        this.posX = pPosX;
        this.posY = pPosY;
        this.timer = timerInstance;
        this.life = life;
        switch (life)
        {
            case 3:
                sprite = Sprites.Ennemy1Sprite;
                break;
            case 4:
                sprite = Raylib.LoadTextureFromImage(Images.Ennemy2Img);
                break;
            case 5:
                sprite = Raylib.LoadTextureFromImage(Images.Ennemy3Img);
                break;
            case 10:
                sprite = Raylib.LoadTextureFromImage(Images.Ennemy4Img);
                break;
            default:
                sprite = Sprites.Ennemy1Sprite;
                break;
        }
    }

    public void Update()
    {
        
        isShooting = false;
        if (ShootTimer())
        {
            isShooting = true;
            Shoot();

            timerInstance = RandomTimer();
        }
        else
        {
            ShootTimer();
        }
        if (IsDead())
        {
            isAlive = false;
        }
    }
    protected void Shoot()
    {
        Console.WriteLine("Bang !");
    }

    protected bool ShootTimer()
    {
        timerInstance -= Raylib.GetFrameTime();

        if (timerInstance <= 0)
            return true;

        return false;
    }

    protected int RandomTimer()
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int timer = rand.Next(3, 10);
        return timer;
    }
    public void TakeDamage()
    {
        
        life--;
    }
    public bool IsDead()
    {
        return life <= 0;
    }

}

