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

            Console.WriteLine($"ID: {i.Key} Name: {i.Value.name} Cost: {i.Value.cost} Rounds: {i.Value.rounds}");
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

    // private void buySomethingFromMeele(List<Item> list)
    // {
    //     Console.WriteLine("If you want to buy something type one of the following:");
    //     Console.WriteLine("(1), (2), (3)");
    //     Console.WriteLine("If you want to go back type (4)");

    //     string tempString = Console.ReadLine();

    //     (string, string, string) tempListString = GetInventory(list);

    //     switch (tempString)
    //     {
    //         case "1":
    //             list.Remove(list.Where(item => item.id == 1).first());
    //             break;
    //         case "2":

    //             break;
    //         case "3":

    //             break;
    //         case "4":

    //             break;
    //         default:
    //             Console.WriteLine("You have to type something from one of the selectives above!");
    //             break;
    //     }
    // }
}
