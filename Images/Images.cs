using Raylib_cs;

public static class Images
{
    public static Image PlayerImg;
    public static Image Ennemy1Img;
    public static Image Ennemy2Img;
    public static Image Ennemy3Img;
    public static Image Ennemy4Img;
    public static Image ShootImg;
    public static int LoadImages()
    {
        PlayerImg = Raylib.LoadImage("assets/sprites/player.png");
        Ennemy1Img = Raylib.LoadImage("assets/sprites/ennemy1.png");
        Ennemy2Img = Raylib.LoadImage("assets/sprites/ennemy2.png");
        Ennemy3Img = Raylib.LoadImage("assets/sprites/ennemy3.png");
        Ennemy4Img = Raylib.LoadImage("assets/sprites/ennemy4.png");
        ShootImg = Raylib.LoadImage("assets/sprites/shoot.png");
        return 0;
    }

}