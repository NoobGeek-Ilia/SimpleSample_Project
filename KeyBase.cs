public class KeyBase
{
    public int keysCollection;
    public List<int> keyCount = new List<int>();
    public List<int> sortedKeys = new List<int>();
    public List<int> kTest = new List<int>();
    public List<int> sortedIndex = new List<int>();

    public List<List<string>> getKey = new List<List<string>>();

    public KeyBase(int num)
    {
        keysCollection = num;
        for (int i = 0; i < keysCollection; i++)
        {
            keyCount.Add(0);
            sortedKeys.Add(0);
            sortedIndex.Add(0);
            getKey.Add(new List<string>());
        }
    }
}