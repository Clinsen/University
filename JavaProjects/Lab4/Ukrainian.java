public class Ukrainian implements Person
{
    private String name;

    Ukrainian()
    {
        this.name = "Undefined";
    }
    Ukrainian(String name)
    {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public void PrintCountryName()
    {
        System.out.println("My country of origin is Ukraine");
    }

    @Override
    public void Speak()
    {
        System.out.println("Привіт!");
    }

    @Override
    public void PrintMyName()
    {
        System.out.println("My name is " + getName());
    }

    public static void SayRandomStuff() {
        System.out.println("Random stuff");
    }
}
