
using Raylib_cs;

public static class GameOver
{
    private static double timer;
    private static bool isInit = false;
    public static void Init() // -------------------------------- INIT TIMER ---------------------------------------------------
    {
        timer = 3;
    }
    public static void Update()  // ------------------------------ TIMER BEFORE RETURNING TO MENU ------------------------------
    {

        if (timer > 0)
        {
            timer -= Raylib.GetFrameTime();
        }
        else
        {
            SceneManager.STATE = "Menu";
        }
    }
    public static void Draw()
    {
        Raylib.DrawText("GAME OVER", 600, 600, 50, Color.Black);
    }
}

