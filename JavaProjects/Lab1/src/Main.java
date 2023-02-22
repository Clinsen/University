import java.util.*;
public class Main {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter value of x: ");
        double x = sc.nextDouble();

        System.out.println("\n=========== Tabulating first function ===========");
        for(int i = -2; i <= 2; i++)
        {
            System.out.println(Math.exp(x+Math.cos(x)));
            x += 0.5;
        }

        System.out.println("\n=========== Tabulating second function ===========");
        if(x < 20)
        {
            for(int i = 19; i <= 22; i++)
            {
                System.out.println(Math.sqrt(2*Math.sin(x) + Math.cos(x)));
                x += 0.4;
            }
        }
        else
        {
            for(int i = 19; i <= 22; i++)
            {
                System.out.println(2*Math.sin(x)-Math.cos(x));
                x += 0.4;
            }
        }
    }
}