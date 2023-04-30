public class Italian implements Person
{
    private String name;

    Italian()
    {
        this.name = "Undefined";
    }
    Italian(String name)
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
        System.out.println("My country of origin is Italy");
    }

    @Override
    public void Speak()
    {
        System.out.println("Chao!");
    }

    @Override
    public void PrintMyName()
    {
        System.out.println("My name is " + getName());
    }
}
