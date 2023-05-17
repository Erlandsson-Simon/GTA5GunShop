public class Item
{
    public string name { get; set; }
    public int cost { get; set; } = 0;
    public int rounds { get; set; } = 0;

    public Item(string tempName, string tempCost, string tempRounds)
    {
        name = tempName;
        cost = int.Parse(tempCost);
        rounds = int.Parse(tempRounds);
    }
}
