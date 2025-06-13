
using Raylib_cs;

public static class Sprites
{
    public static Texture2D PlayerSprite;
    public static Texture2D Ennemy1Sprite;
    public static Texture2D Ennemy2Sprite;
    public static Texture2D Ennemy3Sprite;
    public static Texture2D Ennemy4Sprite;
    public static Texture2D ShootSprite;
    public static int LoadSprites()
    {
        PlayerSprite = Raylib.LoadTextureFromImage(Images.PlayerImg);
        Ennemy1Sprite = Raylib.LoadTextureFromImage(Images.Ennemy1Img);
        Ennemy2Sprite = Raylib.LoadTextureFromImage(Images.Ennemy2Img);
        Ennemy3Sprite = Raylib.LoadTextureFromImage(Images.Ennemy3Img);
        Ennemy4Sprite = Raylib.LoadTextureFromImage(Images.Ennemy4Img);
        ShootSprite = Raylib.LoadTextureFromImage(Images.ShootImg);
        return 0;
    }
}

