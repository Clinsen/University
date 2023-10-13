using _2;

class Program
{
    static void Main(string[] args)
    {
        WolfEventPublisher eventPublisher = new WolfEventPublisher();
        eventPublisher.WolfTooYoungEvent += HandleWolfTooYoungEvent;

        eventPublisher.CheckWolfAge(new Wolf { Name = "Alpha", Age = 0 });
        eventPublisher.CheckWolfAge(new Wolf { Name = "Beta", Age = 1 });
    }

    static void HandleWolfTooYoungEvent(object sender, WolfEventArgs e)
    {
        Console.WriteLine($"Warning: Wolf {e.Wolf.Name} is too young to be kept as a pet!");
    }
}