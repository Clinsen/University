// Декоратор для аксесуарів
public abstract class WeaponDecorator : IWeapon
{
    protected IWeapon _weapon;

    public WeaponDecorator(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public virtual string Name => _weapon.Name;
    public virtual double Range => _weapon.Range;
    public virtual double Power => _weapon.Power;
    public virtual double Weight => _weapon.Weight;

    public abstract double CalculateCost();
}
