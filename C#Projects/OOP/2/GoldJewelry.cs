public class GoldenEarrings : IJewelry
{
    public string GetName() => "Золоті сережки";
    public double GetPrice() => 100;
}

public class GoldenRing : IJewelry
{
    public string GetName() => "Золотий каблучок";
    public double GetPrice() => 150;
}

public class GoldenPendant : IJewelry
{
    public string GetName() => "Золота підвіска";
    public double GetPrice() => 160;
}

public class GoldenBracelet : IJewelry
{
    public string GetName() => "Золотий браслет";
    public double GetPrice() => 120;
}


public class GoldenJewelryFactory : IJewelryFactory
{
    public IJewelry CreateEarrings() => new GoldenEarrings();
    public IJewelry CreateRing() => new GoldenRing();
    public IJewelry CreatePendant() => new GoldenPendant();
    public IJewelry CreateBracelet() => new GoldenBracelet();
}
