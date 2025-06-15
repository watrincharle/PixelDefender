

using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;

static class Player
{
    public static int score;
    public static int posX;
    public static int posY;
    public static int life = 5;
    public static bool isAlive = true;

    public static void Init()
    {
        life = 5;
        isAlive = true;
    }
    public static void PlayerUpdate(int pX, int pY)
    {
        posX = pX - Sprites.PlayerSprite.Width / 2;
        posY = pY;
        if (life <= 0)
        {
            isAlive = false;
        }
    }
    public static void TakeDamage()
    {
        life--;
    }


}

