using Raylib_cs;


public static class DrawGeneral
{
    private static string hudLife = "";

    public static void DrawSprites(Texture2D pSprite, int pPosX, int pPosY)  // ------------------- DRAW SPRITES ------------------------
    {
        Raylib.DrawTexture(pSprite, pPosX, pPosY, Color.White);
    }

    public static void DrawGame()  // ------------------------ REUSABLE DRAW FOR OTHERS LEVELS ------------------------
    {
        Raylib.HideCursor();
        hudLife = $"LIFE : {Player.life}";
        Game.Draw();
        if (!Player.isAlive)
        {
            GameOver.Draw();
        }
        if (SceneManager.STATE == "Pause")
        {
            Pause.Draw();
        }
        Raylib.DrawText(hudLife, 50, 50, 50, Color.Black);
    }
}

