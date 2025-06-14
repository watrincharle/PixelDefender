
using Raylib_cs;

static class Program
{
    static int Main()
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int randEnnemyShoot = rand.Next(3, 6);
        Load.InitScreen();
        Images.LoadImages();
        Sprites.LoadSprites();

        while (!Raylib.WindowShouldClose())
        {
            Level0.Start();
            //---------------------------------UPDATE------------------------------
            Player.PlayerUpdate(Raylib.GetMouseX(), Raylib.GetMouseY());
            foreach (var enemy in Lists.ennemyList)
            {
                enemy.Update();
                if (enemy.isShooting)
                {
                    Lists.shootList.Add(new Shoot(enemy.posX + Sprites.Ennemy1Sprite.Width / 2, enemy.posY + Sprites.Ennemy1Sprite.Height, 1));
                    Console.WriteLine(enemy.posY);
                }
                if (!enemy.isAlive)
                {
                    Lists.ennemyList.Remove(enemy);
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
            Collision.Update();





            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                Lists.shootList.Add(new Shoot(Player.posX + Sprites.PlayerSprite.Width / 2, Player.posY, -1));
            }


            //----------------------------DRAW------------------------------------
            Raylib.BeginDrawing();
            Draw.DrawWindow();
            Level0.Draw();
            Draw.DrawSprites(Sprites.PlayerSprite, Player.posX, Player.posY);

            foreach (var enemy in Lists.ennemyList)
                Draw.DrawSprites(enemy.sprite, enemy.posX, enemy.posY);



            foreach (Shoot sd in Lists.shootList)
            {
                Draw.DrawSprites(Sprites.ShootSprite, sd.posX, sd.posY);
            }
            if (!Player.isAlive)
            {
                Raylib.DrawText("GAME OVER", 600, 600, 50, Color.Black);
            }
            Raylib.EndDrawing();
        }


        Raylib.CloseWindow();
        return 0;
    }
}