public interface IJewelry
{
    string GetName();
    double GetPrice();
}

public interface IJewelryFactory
{
    IJewelry CreateEarrings();
    IJewelry CreateRing();
    IJewelry CreatePendant();
    IJewelry CreateBracelet();
}
