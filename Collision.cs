
class Collision
{


    public static void Update()
    {
        CheckCollisionEnnemy();
        CheckCollisionPlayer();
        CheckCollisionPlayerOnEnnemy();
    }

    private static void CheckCollisionEnnemy()
    {
        foreach (BaseShip b in Lists.ennemyList)
        {
            foreach (Shoot s in Lists.shootList)
            {
                if (s.orientation == -1)
                {
                    if (s.posX + Sprites.ShootSprite.Width >= b.posX && s.posX <= b.posX + Sprites.Ennemy1Sprite.Width && s.posY + Sprites.ShootSprite.Height >= b.posY && s.posY <= b.posY + Sprites.Ennemy1Sprite.Height)
                    {
                        Lists.shootList.Remove(s);
                        b.TakeDamage();
                        break;
                    }
                }

            }
        }
    }
    private static void CheckCollisionPlayer()
    {
        foreach (Shoot ss in Lists.shootList)
        {
            if (ss.orientation == 1)
            {
                if (ss.posX + Sprites.ShootSprite.Width >= Player.posX && ss.posX <= Player.posX + Sprites.PlayerSprite.Width && ss.posY + Sprites.ShootSprite.Height >= Player.posY && ss.posY <= Player.posY + Sprites.PlayerSprite.Height)
                {
                    Lists.shootList.Remove(ss);
                    Player.TakeDamage();
                    break;
                }
            }

        }
    }
    private static void CheckCollisionPlayerOnEnnemy()
    {
        foreach (BaseShip e in Lists.ennemyList)
        {
            if (e.posX + Sprites.Ennemy1Sprite.Width >= Player.posX && e.posX <= Player.posX + Sprites.PlayerSprite.Width && e.posY + Sprites.Ennemy1Sprite.Height >= Player.posY && e.posY <= Player.posY + Sprites.PlayerSprite.Height)
            {
                Lists.ennemyList.Remove(e);
                Player.TakeDamage();
            }
        }
    }
}

