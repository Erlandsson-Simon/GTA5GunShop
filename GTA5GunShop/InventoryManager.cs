public class InventoryManager
{

    public Dictionary<int, Item> inventory = new Dictionary<int, Item>();
    public int Money { get; set; }

    protected InventoryManager()
    {

    }

    private int weaponPrintCount = 0;
    private int tempInt = 0;

    public void printInventory()
    {
        int tempInt = 0;

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();

        foreach (var i in inventory)
        {
            if (tempInt == 0)
            {
                Console.WriteLine("               Meele weapons");
            }

            Console.WriteLine($"ID: {i.Key} Name: {i.Value.name} Cost: ${i.Value.cost} Rounds: {i.Value.rounds}");
            tempInt++;
            if (tempInt == 3 || tempInt == 6)
            {
                Console.WriteLine();
                if (tempInt == 3)
                {
                    Console.WriteLine("               Handguns");
                }
                else if (tempInt == 6)
                {
                    Console.WriteLine("               Rifles");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
    }
}
