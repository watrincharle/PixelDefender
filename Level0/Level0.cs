
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
                Lists.ennemyList.Add(new Enemy(100, 0, 3));
                Lists.ennemyList.Add(new Enemy(300, 0, 3));
                Lists.ennemyList.Add(new Enemy(500, 0, 3));
                Lists.ennemyList.Add(new Enemy(700, 0, 3));
                Lists.ennemyList.Add(new Enemy(900, 0, 3));
                isWave101Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave102Launched)
            {
                Lists.ennemyList.Add(new Enemy(100, 0, 4));
                Lists.ennemyList.Add(new Enemy(300, 0, 4));
                Lists.ennemyList.Add(new Enemy(500, 0, 4));
                Lists.ennemyList.Add(new Enemy(700, 0, 4));
                Lists.ennemyList.Add(new Enemy(900, 0, 4));
                isWave102Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave103Launched)
            {
                Lists.ennemyList.Add(new Enemy(100, 0, 5));
                Lists.ennemyList.Add(new Enemy(300, 0, 5));
                Lists.ennemyList.Add(new Enemy(500, 0, 5));
                Lists.ennemyList.Add(new Enemy(700, 0, 5));
                Lists.ennemyList.Add(new Enemy(900, 0, 5));
                isWave103Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave104Launched)
            {
                Lists.ennemyList.Add(new Enemy(100, 0, 10));
                Lists.ennemyList.Add(new Enemy(300, 0, 10));
                Lists.ennemyList.Add(new Enemy(500, 0, 10));
                Lists.ennemyList.Add(new Enemy(700, 0, 10));
                Lists.ennemyList.Add(new Enemy(900, 0, 10));
                isWave104Launched = true;
            }
            if (isWave101Launched && Lists.ennemyList.Count == 0 && !isWave105Launched)
            {
                Lists.ennemyList.Add(new Enemy(100, 0, 3));
                Lists.ennemyList.Add(new Enemy(300, 0, 4));
                Lists.ennemyList.Add(new Enemy(500, 0, 5));
                Lists.ennemyList.Add(new Enemy(700, 0, 10));
                Lists.ennemyList.Add(new Enemy(900, 0, 3));
                isWave105Launched = true;
            }

            DropFromTheTop();


            
        }
        

        Console.WriteLine(Lists.ennemyList.Count);


        return false;
    }


    private static void DropFromTheTop()
    {
        foreach (var enemy in Lists.ennemyList)
        {
            if (enemy.posY < 150)
                enemy.posY += 5;
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

