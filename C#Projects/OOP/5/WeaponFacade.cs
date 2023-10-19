// Фасад для спрощення взаємодії з різними видами зброї та аксесуарами
public class WeaponFacade
{
    public IWeapon GetRifleWithAccessories()
    {
        IWeapon rifle = new Rifle();
        return new NightVisionScope(new Suppressor(rifle));
    }

    public IWeapon GetPistolWithAccessories()
    {
        IWeapon pistol = new Pistol();
        return new Suppressor(pistol);
    }
}