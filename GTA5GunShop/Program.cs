global using System.IO;

AmmuNation a = new AmmuNation();
Player p = new Player();

foreach (var i in a.meeleInventory)
{
    Console.WriteLine($"Name: {i.name}");
    Console.WriteLine($"Cost: {i.cost}");
    Console.WriteLine($"Rounds: {i.rounds}");

}

Console.ReadLine();