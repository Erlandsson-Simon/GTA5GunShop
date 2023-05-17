public class InventoryManager
{
    public List<Item> meeleInventory = new List<Item>();
    public List<Item> handgunInventory = new List<Item>();
    public List<Item> rifleInventory = new List<Item>();

    public List<List<Item>> inventory = new List<List<Item>>();
    public int Money { get; set; }

    protected InventoryManager()
    {
        inventory.Add(meeleInventory);
        inventory.Add(handgunInventory);
        inventory.Add(rifleInventory);
    }

}
