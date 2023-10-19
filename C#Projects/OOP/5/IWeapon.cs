// Інтерфейс для зброї
public interface IWeapon
{
    string Name { get; }
    double Range { get; }
    double Power { get; }
    double Weight { get; }
    double CalculateCost();
}