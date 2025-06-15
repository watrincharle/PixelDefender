
using Raylib_cs;
using System.Numerics;

public static class Menu
{
    public static int divW = 200;
    public static int divH = 70;
    private static string play = "PLAY";
    public static string exit = "EXIT";
    public static int howToCenterADiv = (Raylib.GetScreenWidth() / 2) - (divW / 2);
    public static int mX;
    public static int mY;

    public static void Update()  // ------------------------------ I DON'T KNOW WHY I PUT THIS HERE -------------------------------
    {
        mX = Raylib.GetMouseX();
        mY = Raylib.GetMouseY();
    }
    public static void Draw()  // -------------------------------- DRAW DIVS (BUTTONS) START/EXIT ----------------------------------
    {
        Raylib.ShowCursor();
        Raylib.DrawRectangle(howToCenterADiv, 500, divW, divH, Color.Gray);
        Raylib.DrawRectangle(howToCenterADiv, 700, divW, divH, Color.Gray);
        Raylib.DrawText(play, howToCenterADiv + 45, 515, 40, Color.White);
        Raylib.DrawText(exit, howToCenterADiv + 45, 715, 40, Color.White);
    }

    public static void isDivClicked() // ------------------------ CHECK IF BUTTONS IS PRESSED -----------------------------------
    {
        if (mX >= howToCenterADiv && mX <= howToCenterADiv + divW && mY >= 500 && mY <= 500 + divH)
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                Level0.Init();
                Player.Init();
                Lists.Init();
                SceneManager.STATE = "Game";
            }
        }
        if (mX >= howToCenterADiv && mX <= howToCenterADiv + divW && mY >= 700 && mY <= 700 + divH)
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                Raylib.EndDrawing();
                Raylib.CloseWindow();
                System.Environment.Exit(1);
            }
        }
    }
}

