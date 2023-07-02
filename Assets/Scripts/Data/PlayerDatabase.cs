using System.Collections.Generic;

public static class PlayerDatabase 
{
    private static List<PlayerData> _data;
    private static void Init() 
    {
        _data = new List<PlayerData>() { new PlayerData(1032034, 0, 12000), new PlayerData(1535671, 1, 11500), new PlayerData(1533371, 2, 10000), new PlayerData(2230671, 0, 9000), new PlayerData(1539071, 3, 15670), new PlayerData(1537671, 1, 10800) };
    }

    public static List<PlayerData> GetData()
    {
        Init();
        return _data;
    }
}
