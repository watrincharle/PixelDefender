using Raylib_cs;


public static class Draw
{
    public static int DrawWindow()
    {
        Raylib.ClearBackground(Color.White);
        return 0;
    }

    public static void DrawSprites(Texture2D pSprite, int pPosX, int pPosY)
    {
        Raylib.DrawTexture(pSprite, pPosX, pPosY, Color.White);
        
    }

}

