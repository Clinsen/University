import java.util.Objects;

public class Main {
    public static void main(String[] args)
    {
        Italian person1 = new Italian("Bob");
        person1.setName("Blanco");
        person1.PrintCountryName();
        person1.Speak();
        person1.PrintMyName();

        System.out.println();

        Ukrainian person2 = new Ukrainian("Andriy");
        person2.setName("Ruslan");
        person2.PrintCountryName();
        person2.Speak();
        person2.PrintMyName();

        System.out.println();

        Ukrainian.SayRandomStuff();

        System.out.println();

        System.out.println(person1.getName().equals(person2.getName()));
    }
}