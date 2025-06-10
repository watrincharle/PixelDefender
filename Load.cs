using Raylib_cs;


namespace PixelDefender
{
    public static class Load
    {
        public static int InitScreen()
        {
            Raylib.InitWindow(1600, 900, "PixelDefender");
            Raylib.SetTargetFPS(60);


            return 0;
        }
    }
}
