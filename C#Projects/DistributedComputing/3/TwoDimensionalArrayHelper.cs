using System;

public class TwoDimensionalArrayHelper<T> where T : IComparable<T>, new()
{
    private T[,] array;

    public TwoDimensionalArrayHelper(T[,] inputArray)
    {
        array = inputArray;
    }

    public int CountColumnsWithZeroElement()
    {
        int count = 0;
        int columns = array.GetLength(1);

        for (int i = 0; i < columns; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if (array[j, i].Equals(new T()))
                {
                    hasZero = true;
                    break;
                }
            }

            if (hasZero)
            {
                count++;
            }
        }

        return count;
    }

    public int RowWithMostEqualElements()
    {
        int maxCount = 0;
        int rowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int currentCount = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j].Equals(array[i, 0]))
                {
                    currentCount++;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                rowIndex = i;
            }
        }

        return rowIndex;
    }
}
