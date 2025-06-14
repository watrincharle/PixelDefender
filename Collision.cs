
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
        int spriteWidth = Sprites.Ennemy1Sprite.Width;
        int spriteHeight = Sprites.Ennemy1Sprite.Height;
        foreach (var enemy in Lists.ennemyList)
        {
            foreach (Shoot s in Lists.shootList)
            {
                if (s.orientation == -1)
                {
                    if (s.posX + Sprites.ShootSprite.Width >= enemy.posX && s.posX <= enemy.posX + spriteWidth && s.posY + spriteHeight >= enemy.posY && s.posY <= enemy.posY + spriteHeight)
                    {
                        Lists.shootList.Remove(s);
                        enemy.TakeDamage();
                        break;
                    }
                }

            }
        }
    }
    private static void CheckCollisionPlayer()
    {
        int spriteWidth = Sprites.PlayerSprite.Width;
        int spriteHeight = Sprites.PlayerSprite.Height;
        foreach (Shoot ss in Lists.shootList)
        {
            if (ss.orientation == 1)
            {
                if (ss.posX + Sprites.ShootSprite.Width >= Player.posX && ss.posX <= Player.posX + spriteWidth && ss.posY + spriteHeight >= Player.posY && ss.posY <= Player.posY + spriteHeight)
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
        int enemySpriteWidth = Sprites.Ennemy1Sprite.Width;
        int enemySpriteHeight = Sprites.Ennemy1Sprite.Height;
        int playerSpriteWidth = Sprites.PlayerSprite.Width;
        int playerSpriteHeight = Sprites.PlayerSprite.Height;
        foreach (var enemy in Lists.ennemyList)
        {
            if (enemy.posX + enemySpriteWidth >= Player.posX && enemy.posX <= Player.posX + playerSpriteWidth && enemy.posY + enemySpriteHeight >= Player.posY && enemy.posY <= Player.posY + playerSpriteHeight)
            {
                Lists.ennemyList.Remove(enemy);
                Player.TakeDamage();
            }
        }
    }
}

