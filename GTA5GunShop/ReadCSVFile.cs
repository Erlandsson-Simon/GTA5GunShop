public class ReadCSVFile
{
    public static Dictionary<int, Item> ReadFile(string fileName)
    {
        List<string> lines = File.ReadAllLines($"{fileName}").ToList();
        Dictionary<int, Item> tempDic = new Dictionary<int, Item>();

        int tempId = 1;

        foreach (var row in lines)
        {
            String[] item = row.Split(',');

            tempDic.Add(tempId, new Item(item[0], item[1], item[2]));

            tempId++;
        }

        return tempDic;
    }
}