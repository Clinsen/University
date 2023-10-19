// Конкретні реалізації декоратора (аксесуари)
public class NightVisionScope : WeaponDecorator
{
    public NightVisionScope(IWeapon weapon) : base(weapon) { }

    public override double Range => _weapon.Range + 200;
    public override double CalculateCost()
    {
        return _weapon.CalculateCost() + 150;
    }
}

public class Suppressor : WeaponDecorator
{
    public Suppressor(IWeapon weapon) : base(weapon) { }

    public override double Power => _weapon.Power - 1;
    public override double CalculateCost()
    {
        return _weapon.CalculateCost() + 80;
    }
}