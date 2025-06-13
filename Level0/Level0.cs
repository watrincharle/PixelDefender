
using Raylib_cs;

public static class Level0
{
    private static double timer1 = 3;
    private static double timerWave1 = 3;
    
    private static bool isStarted = true;
    private static bool isWave1Start = false;
    private static bool isWave101Launched = false;
    private static bool isWave102Launched = false;
    private static bool isWave103Launched = false;
    private static bool isWave104Launched = false;
    private static bool isWave105Launched = false;
    public static void Start()
    {
        if (timer1 > 0)
        {
            timer1 -= Raylib.GetFrameTime();
        }
        else
        {
            isStarted = false;
            isWave1Start = true;
            Wave1();
        }
        

    }

    private static bool Wave1()
    {
        if (timerWave1 > 0)
        {
            timerWave1 -= Raylib.GetFrameTime();
        }
        else
        {
            isWave1Start = false;
        }

        if (!isWave1Start)
        {
            if (!isWave101Launched)
            {
                Lists.ennemyList.Add(new Ennemy1(100, 0));
                Lists.ennemyList.Add(new Ennemy1(300, 0));
                Lists.ennemyList.Add(new Ennemy1(500, 0));
                Lists.ennemyList.Add(new Ennemy1(700, 0));
                Lists.ennemyList.Add(new Ennemy1(900, 0));
                isWave101Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave102Launched)
            {
                Lists.ennemyList.Add(new Ennemy2(100, 0));
                Lists.ennemyList.Add(new Ennemy2(300, 0));
                Lists.ennemyList.Add(new Ennemy2(500, 0));
                Lists.ennemyList.Add(new Ennemy2(700, 0));
                Lists.ennemyList.Add(new Ennemy2(900, 0));
                isWave102Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave103Launched)
            {
                Lists.ennemyList.Add(new Ennemy3(100, 0));
                Lists.ennemyList.Add(new Ennemy3(300, 0));
                Lists.ennemyList.Add(new Ennemy3(500, 0));
                Lists.ennemyList.Add(new Ennemy3(700, 0));
                Lists.ennemyList.Add(new Ennemy3(900, 0));
                isWave103Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave104Launched)
            {
                Lists.ennemyList.Add(new Ennemy4(100, 0));
                Lists.ennemyList.Add(new Ennemy4(300, 0));
                Lists.ennemyList.Add(new Ennemy4(500, 0));
                Lists.ennemyList.Add(new Ennemy4(700, 0));
                Lists.ennemyList.Add(new Ennemy4(900, 0));
                isWave104Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave105Launched)
            {
                Lists.ennemyList.Add(new Ennemy1(100, 0));
                Lists.ennemyList.Add(new Ennemy2(300, 0));
                Lists.ennemyList.Add(new Ennemy3(500, 0));
                Lists.ennemyList.Add(new Ennemy4(700, 0));
                Lists.ennemyList.Add(new Ennemy1(900, 0));
                isWave105Launched = true;
            }

            DropFromTheTop();


            
        }
        

        Console.WriteLine(Lists.ennemyList.Count);


        return false;
    }


    private static void DropFromTheTop()
    {
        foreach (BaseShip b in Lists.ennemyList)
        {
            if (b is Ennemy1 e1)
            {
                if (e1.posY < 150)
                {
                    e1.posY += 5;
                }
            }
            if (b is Ennemy2 e2)
            {
                if (e2.posY < 150)
                {
                    e2.posY += 5;
                }
            }
            if (b is Ennemy3 e3)
            {
                if (e3.posY < 150)
                {
                    e3.posY += 5;
                }
            }
            if (b is Ennemy4 e4)
            {
                if (e4.posY < 150)
                {
                    e4.posY += 5;
                }
            }
        }
    }
    public static void Draw()
    {
        if (isStarted)
        {
            Raylib.DrawText("LEVEL 0 : PROTOTYPE", 450, 200, 50, Color.Black);
        }
        if (isWave1Start)
        {
            Raylib.DrawText("WAVE 1 START", 550, 200, 50, Color.Black);
        }

    }

}

