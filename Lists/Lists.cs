
public static class Lists
{
    public static List<EnnemyParent> ennemyList = new List<EnnemyParent>();
    public static List<Shoot> shootList = new List<Shoot>();

    public static void Init()
    {
        ennemyList.Clear();
        shootList.Clear();
    }
}

