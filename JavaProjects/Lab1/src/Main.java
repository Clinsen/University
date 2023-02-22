public class Main {
    public static void main(String[] args)
    {
        System.out.println("\n=========== Tabulating first function ===========");
        for(double x = -2; x <= 2; x += 0.5)
        {
            System.out.print("y = ");
            System.out.println(Math.exp(x+Math.cos(x)));
        }

        System.out.println("\n=========== Tabulating second function ===========");

        for(double x = 19; x <= 22; x += 0.4)
        {
            System.out.print("y = ");
            if (x >= 20)
            {
                System.out.println(2 * Math.sin(x) - Math.cos(x));

            }
            else
            {
                System.out.println(Math.sqrt(2 * Math.sin(x) + Math.cos(x)));
            }
        }

        System.out.println("\n=========== Matrix ===========");
        int[][] matrix = new int[10][10];

        // Наповнення матриці рандомними даними
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i][j] = (int)(Math.random() * 100);
            }
        }

        // Виведення її на екран
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                System.out.print(matrix[i][j] + "  ");
                if (j == 9)
                {
                    System.out.print("\n");
                }
            }
        }

        // Знаходження мінімального значення серед елементів масиву що розміщені нижче головної діагоналі
        int min_matrix_element = 100;

        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if  (j < i)
                {
                    if (min_matrix_element > matrix[i][j])
                    {
                        min_matrix_element = matrix[i][j];
                    }
                }
            }
        }
        System.out.println("\n=========== Smallest element of the matrix underneath the main diagonal ===========");
        System.out.println(min_matrix_element);
    }
}