global using System.IO;

bool inStore = true;

bool inLoop = false;
bool buying = false;
string tempString;


Ammunation a = new Ammunation();
Player p = new Player();

Console.WriteLine("Hello friend, Welcome to Ammunation!");
Console.WriteLine("We have a varity of self defence weapons.");
Console.WriteLine("They are devided into 3 catagories.");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("(1): Meele Weapons, (2): Handguns, (3): Rifles");
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine("Press ENTER to continue");
Console.ReadLine();
Console.Clear();

a.inventory = ReadCSVFile.ReadFile("AllWeapons.csv");

while (inStore = true)
{
    inLoop = true;
    while (inLoop)
    {
        Console.WriteLine("If you are intrested in buying something type (Buy)");
        Console.WriteLine("If you want to see your inventory type (Inv)");
        Console.WriteLine("If you want to leave the store type (Leave)");

        tempString = Console.ReadLine();

        switch (tempString.ToLower())
        {
            case "buy":
                buying = true;
                inLoop = false;
                break;

            case "inv":
                p.printInventory();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                break;

            case "leave":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("You have to type something from one of the selectives above!");
                Console.WriteLine("Press ENTER if you understand.");
                Console.ReadLine();
                break;
        }
        Console.Clear();
    }

    p = a.buySomething(buying, p);
}

Console.ReadLine();