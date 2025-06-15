
using Raylib_cs;

static class Program
{
    static int Main()
    {
        // -----------------------------------LOAD--------------------------------
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int randEnnemyShoot = rand.Next(3, 6);
        Load.InitScreen();
        Images.LoadImages();
        Sprites.LoadSprites();
        SceneManager.Load();
        //---------------------------------------------------------------------------
        while (!Raylib.WindowShouldClose())
        {
            Menu.Update();
            //---------------------------------UPDATE------------------------------
            if (SceneManager.STATE == "Menu")
            {
                Menu.isDivClicked();
            }
            else if (SceneManager.STATE == "Game")
            {
                Level0.Update();
            }
            else if (SceneManager.STATE == "Pause")
            {
                if (Raylib.IsKeyPressed(KeyboardKey.P))
                {
                    SceneManager.STATE = "Game";
                }
            }
            else if (SceneManager.STATE == "GameOver")
            {
                GameOver.Update();
            }
                //----------------------------DRAW------------------------------------
            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(Color.White);
            if (SceneManager.STATE == "Game" || SceneManager.STATE == "Pause")
            {
                Level0.Draw();
            }
            if (SceneManager.STATE == "Menu")
            {
                Menu.Draw();
            }
            if (SceneManager.STATE == "GameOver")
            {
                GameOver.Draw();
            }
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
        return 0;
    }
}