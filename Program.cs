
using PixelDefender;
using Raylib_cs;

static class Program
{
    static int Main()
    {
        Load.InitScreen();




        while (!Raylib.WindowShouldClose())
        {

            //---------------------------------UPDATE------------------------------





            //----------------------------DRAW------------------------------------
            Raylib.BeginDrawing();
            Draw.DrawWindow();
            Raylib.EndDrawing();
        }


        Raylib.CloseWindow();
        return 0;
    }
}