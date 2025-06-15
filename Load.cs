using Raylib_cs;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;



public static class Load
{
    public static int InitScreen()
    {
        Raylib.InitWindow(1600, 900, "PixelDefender");
        Raylib.SetTargetFPS(60);
        return 0;
    }
}
