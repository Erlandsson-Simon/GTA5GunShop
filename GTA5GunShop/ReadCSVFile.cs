public class ReadCSVFile
{
    public static List<Item> ReadFile(string fileName)
    {
        List<string> lines = File.ReadAllLines($"{fileName}").ToList();
        List<Item> tempList = new List<Item>();

        foreach (var row in lines)
        {
            String[] item = row.Split(',');

            tempList.Add(new Item(item[0], item[1], item[2]));
        }

        return tempList;
    }
}