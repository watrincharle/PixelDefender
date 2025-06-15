
using Raylib_cs;

public static class Game
{

    public static void Update() // --------------------------- UPDATE LISTS, COLLISIONS, DEAD OF OBJECTS. REUSABLE ON OTHERS LEVELS --------------
    {
        Player.PlayerUpdate(Menu.mX, Menu.mY);
        Collision.Update();
        foreach (EnnemyParent e in Lists.ennemyList)
        {
            e.Update();
            if (e.isShooting)
            {
                Lists.shootList.Add(new Shoot(e.posX + Sprites.Ennemy1Sprite.Width / 2, e.posY + Sprites.Ennemy1Sprite.Height, 1));
                Console.WriteLine(e.posY);
            }
            if (!e.isAlive)
            {
                Lists.ennemyList.Remove(e);
                break;
            }
        }

        foreach (Shoot s in Lists.shootList)
        {
            s.Update();
            if (!s.isAlive)
            {
                Lists.shootList.Remove(s);
                break;
            }
        }
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            Lists.shootList.Add(new Shoot(Player.posX + Sprites.PlayerSprite.Width / 2, Player.posY, -1));
        }
        if (Raylib.IsKeyPressed(KeyboardKey.P))
        {
            SceneManager.STATE = "Pause";
        }
        if (!Player.isAlive)
        {
            SceneManager.STATE = "GameOver";
        }
    }
    public static void Draw() // ------------------------------------ DRAW ALL SPRITES OF THE LVL --------------------------------
    {
        DrawGeneral.DrawSprites(Sprites.PlayerSprite, Player.posX, Player.posY);
        foreach (EnnemyParent bs in Lists.ennemyList)
        {
            if (bs is Ennemy1 e1)
            {
                DrawGeneral.DrawSprites(Sprites.Ennemy1Sprite, e1.posX, e1.posY);
            }
            else if (bs is Ennemy2 e2)
            {
                DrawGeneral.DrawSprites(Sprites.Ennemy2Sprite, e2.posX, e2.posY);
            }
            else if (bs is Ennemy3 e3)
            {
                DrawGeneral.DrawSprites(Sprites.Ennemy3Sprite, e3.posX, e3.posY);
            }
            else if (bs is Ennemy4 e4)
            {
                DrawGeneral.DrawSprites(Sprites.Ennemy4Sprite, e4.posX, e4.posY);
            }
        }
        foreach (Shoot sd in Lists.shootList)
        {
            DrawGeneral.DrawSprites(Sprites.ShootSprite, sd.posX, sd.posY);
        }
    }
}

