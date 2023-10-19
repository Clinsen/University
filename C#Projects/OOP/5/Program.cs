class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        WeaponFacade weaponFacade = new WeaponFacade();

        IWeapon rifleWithAccessories = weaponFacade.GetRifleWithAccessories();
        Console.WriteLine($"Рушниця з покращеннями - Ім'я: {rifleWithAccessories.Name}, " +
            $"Дальність: {rifleWithAccessories.Range}, Сила: {rifleWithAccessories.Power}, " +
            $"Вага (кг): {rifleWithAccessories.Weight}, Ціна: {rifleWithAccessories.CalculateCost()}");

        IWeapon pistolWithAccessories = weaponFacade.GetPistolWithAccessories();
        Console.WriteLine($"Пістолет з покращеннями - Ім'я: {pistolWithAccessories.Name}, " +
            $"Дальність: {pistolWithAccessories.Range}, Сила: {pistolWithAccessories.Power}, " +
            $"Вага (кг): {pistolWithAccessories.Weight}, Ціна: {pistolWithAccessories.CalculateCost()}");

        Console.ReadLine();
    }
}
