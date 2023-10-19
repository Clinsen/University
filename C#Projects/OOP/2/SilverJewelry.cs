public class SilverEarrings : IJewelry
{
    public string GetName() => "Срібні сережки";
    public double GetPrice() => 55;
}

public class SilverRing : IJewelry
{
    public string GetName() => "Срібний каблучок";
    public double GetPrice() => 80;
}

public class SilverPendant : IJewelry
{
    public string GetName() => "Срібна підвіска";
    public double GetPrice() => 85;
}

public class SilverBracelet : IJewelry
{
    public string GetName() => "Срібний браслет";
    public double GetPrice() => 65;
}

public class SilverJewelryFactory : IJewelryFactory
{
    public IJewelry CreateEarrings() => new SilverEarrings();
    public IJewelry CreateRing() => new SilverRing();
    public IJewelry CreatePendant() => new SilverPendant();
    public IJewelry CreateBracelet() => new SilverBracelet();
}
