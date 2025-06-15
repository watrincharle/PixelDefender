
using Raylib_cs;

public static class Pause
{

    public static void Draw()
    {
        Raylib.ShowCursor();
        Raylib.DrawText("PAUSE", 650, 450, 50, Color.Red);
        Raylib.DrawRectangle(Menu.howToCenterADiv, 700, Menu.divW, Menu.divH, Color.Gray);
        Raylib.DrawText(Menu.exit, Menu.howToCenterADiv + 45, 715, 40, Color.White);
    }

    public static void Update()
    {
        Menu.Update();
        if (Menu.mX >= Menu.howToCenterADiv && Menu.mX <= Menu.howToCenterADiv + Menu.divW && Menu.mY >= 700 && Menu.mY <= 700 + Menu.divH)
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                SceneManager.STATE = "Menu";
            }
        }
    }
}

