using System;

class Matrix
{
    private int[,] data;

    public int Rows
    {
        get { return data.GetLength(0); }
    }

    public int Columns
    {
        get { return data.GetLength(1); }
    }
    public int this[int i, int j]
    {
        get { return data[i, j]; }
    }

    // Випадкові значення для матриці від -10 до 10
    public Matrix(int rows, int columns)
    {
        data = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                data[i, j] = random.Next(-10, 11);
            }
        }
    }

    public int FindFirstNonNegativeColumn()
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

    public int SumOfRowsWithNegativeElement()
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

    public void SortRowsByPositiveElementsCount()
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

    public void DisplayMatrix(string message)
    {
        Console.WriteLine($"{message}:");
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write($"{data[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
