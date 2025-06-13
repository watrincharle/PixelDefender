
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
            foreach (BaseShip e in Lists.ennemyList)
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

            foreach (BaseShip bs in Lists.ennemyList)
            {
                if (bs is Ennemy1 e1)
                {
                    Draw.DrawSprites(Sprites.Ennemy1Sprite, e1.posX, e1.posY);
                }
                else if (bs is Ennemy2 e2)
                {
                    Draw.DrawSprites(Sprites.Ennemy2Sprite, e2.posX, e2.posY);
                }
                else if (bs is Ennemy3 e3)
                {
                    Draw.DrawSprites(Sprites.Ennemy3Sprite, e3.posX, e3.posY);
                }
                else if (bs is Ennemy4 e4)
                {
                    Draw.DrawSprites(Sprites.Ennemy4Sprite, e4.posX, e4.posY);
                }
            }

           
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