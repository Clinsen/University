using System;

class Matrix
{
    private int[,] data;
    private Semaphore semaphore = new Semaphore(1, 1);
    private Mutex mutex = new Mutex();

    // Конструктор ініціалізує матрицю з випадковими значеннями
    public Matrix(int rows, int columns)
    {
        data = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                data[i, j] = random.Next(-100, 101);
            }
        }
    }

    // Пошук першого стовбця без негативних значень
    public int FindFirstNonNegativeColumn()
    {
        semaphore.WaitOne();
        try
        {
            for (int j = 0; j < Columns; j++)
            {
                bool hasNegativeElement = false;
                for (int i = 0; i < Rows; i++)
                {
                    if (data[i, j] < 0)
                    {
                        hasNegativeElement = true;
                        break;
                    }
                }

                if (!hasNegativeElement)
                {
                    return j;
                }
            }

            return -1;
        }
        finally
        {
            semaphore.Release();
        }
    }

    // Логіка для підрахунку кількості позитивних елементів у вказаному рядку
    public int CountPositiveElementsInRow(int rowIndex)
    {
        int count = 0;
        for (int j = 0; j < Columns; j++)
        {
            if (data[rowIndex, j] > 0)
            {
                count++;
            }
        }

        return count;
    }

    // Сортування за кількістю від'ємних елементів
    public int SumOfRowsWithNegativeElement()
    {
        mutex.WaitOne();
        try
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                bool hasNegativeElement = false;
                for (int j = 0; j < Columns; j++)
                {
                    if (data[i, j] < 0)
                    {
                        hasNegativeElement = true;
                        break;
                    }
                }

                if (hasNegativeElement)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        sum += data[i, j];
                    }
                }
            }

            return sum;
        }
        finally
        {
            mutex.ReleaseMutex();
        }
    }

    // Сортування за кількістю додатніх елементів
    public void SortRowsByPositiveElementsCount()
    {
        mutex.WaitOne();
        try
        {
            var query = from row in Enumerable.Range(0, Rows)
                        let positiveCount = CountPositiveElementsInRow(row)
                        orderby positiveCount
                        select row;

            var sortedRows = query.ToArray();
            int[,] newData = new int[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    newData[i, j] = data[sortedRows[i], j];
                }
            }

            data = newData;
        }
        finally
        {
            mutex.ReleaseMutex();
        }
    }


    // Публічні властивості для отримання кількості рядків і стовпців
    public int Rows
    {
        get { return data.GetLength(0); }
    }

    public int Columns
    {
        get { return data.GetLength(1); }
    }

    // Індексатор для отримання значення матриці за індексами
    public int this[int i, int j]
    {
        get { return data[i, j]; }
    }
}
