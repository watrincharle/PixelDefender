

using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;

public class BaseShip
{
    protected int life;
    public bool isAlive;
    public int posX;
    public int posY;
    protected double timer;
    protected double timerInstance = 0;
    public bool isShooting;

    public BaseShip(int pPosX, int pPosY)
    {
        this.posX = pPosX;
        this.posY = pPosY;
        this.timer = timerInstance;
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
    virtual public void TakeDamage()
    {
        
    }
    virtual protected bool IsDead()
    {
        
        return false;
    }

}

