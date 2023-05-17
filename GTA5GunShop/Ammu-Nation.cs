public class AmmuNation : InventoryManager
{
    public AmmuNation()
    {
        meeleInventory = ReadCSVFile.ReadFile("MeeleWeapons.csv");

        handgunInventory = ReadCSVFile.ReadFile("Handguns.csv");

        rifleInventory = ReadCSVFile.ReadFile("Rifles.csv");
    }
}
