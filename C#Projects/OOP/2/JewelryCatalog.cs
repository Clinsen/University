using JewelryApp;

public class JewelryCatalog
{
    private List<Jewelry> jewelryList;

    public JewelryCatalog()
    {
        jewelryList = new List<Jewelry>();
    }

    public void AddJewelry(Jewelry jewelry)
    {
        jewelryList.Add(jewelry);
    }

    public void DisplayCatalog()
    {
        foreach (var jewelry in jewelryList)
        {
            Console.WriteLine(jewelry);
        }
    }
}