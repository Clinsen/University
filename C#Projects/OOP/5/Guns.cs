// Реалізація інтерфейсу для різних видів зброї
public class Rifle : IWeapon
{
    public string Name => "Rifle";
    public double Range => 500;
    public double Power => 4;
    public double Weight => 3;

    public double CalculateCost()
    {
        return 200;
    }
}

public class Pistol : IWeapon
{
    public string Name => "Pistol";
    public double Range => 100;
    public double Power => 2;
    public double Weight => 1.5;

    public double CalculateCost()
    {
        return 100;
    }
}