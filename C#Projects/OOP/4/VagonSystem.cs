// Інтерфейс для сучасної системи вагону
public interface INewVagonSystem
{
    void MatchSocket();
}

// Клас, що реалізує сучасну систему вагону
public class NewVagonSystem : INewVagonSystem
{
    public void MatchSocket()
    {
        Console.WriteLine("Ноутбук заряджається в новому вагоні.");
    }
}

// Інтерфейс для старої системи вагону
public interface IOldVagonSystem
{
    void ThinSocket();
}

// Клас, що реалізує стару систему вагону
public class OldVagonSystem : IOldVagonSystem
{
    public void ThinSocket()
    {
        Console.WriteLine("Ноутбук не може заряджатися в старому вагоні через вузьку розетку.");
    }
}
