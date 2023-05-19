public class Ammunation : InventoryManager
{
    public Ammunation()
    {

    }

    public Player buySomething(bool buying, Player p)
    {

        while (buying = true)
        {
            Console.WriteLine("Here is everything you can buy:");
            printInventory();

            Console.WriteLine("Type the ID of what you want to buy if you want to buy something");
            Console.WriteLine("If you are not intrested in anything right now you can type EXIT to come back to the previous choices");

            Console.WriteLine($"You have ${p.Money}");

            string tempString = Console.ReadLine();

            bool succes = Int32.TryParse(tempString, out int tempInt);

            if (tempString.ToLower() == "exit")
            {
                buying = false;
                Console.Clear();
            }
            else if (tempInt > 0 && tempInt < 10)
            {
                foreach (var i in inventory)
                {
                    if (tempInt == i.Key)
                    {
                        if (i.Value.cost <= p.Money)
                        {
                            bool itemChecked = false;
                            foreach (var j in p.inventory)
                            {
                                if (!(i.Key == j.Key))
                                {
                                    p.inventory.Add(i.Key, i.Value);
                                    p.Money -= i.Value.cost;
                                    buying = false;
                                    Console.Clear();

                                    itemChecked = true;
                                }
                                else
                                {
                                    Console.WriteLine("You already have this Item, Try another one!");
                                    buying = false;
                                    Console.Clear();

                                    itemChecked = true;
                                }
                            }
                            if (itemChecked == false)
                            {
                                p.inventory.Add(i.Key, i.Value);
                                p.Money -= i.Value.cost;
                                buying = false;
                                Console.Clear();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You have to type something from one of the selectives above!");
                Console.WriteLine("Press ANYTHING if you understand");
                Console.ReadLine();
                Console.Clear();
            }
        }
        return p;
    }
}
