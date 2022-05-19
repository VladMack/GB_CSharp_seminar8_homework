Console.Clear();

Console.WriteLine("Введи высоту и ширину массива через пробел:");
int[] lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = lenghts[0];
int n = lenghts[1];
Console.WriteLine();

int[,] numbers = GetArray(m, n, 0, 9);
PrintArray(numbers);
Console.WriteLine();
SortInStrings(numbers);
PrintArray(numbers);

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}

void SortInStrings(int[,] array)
{
    int min, minI, minJ;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        minI = i;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            minJ = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] < array[minI, minJ]) minJ = k;
            min = array[i, j];
            array[i, j] = array[minI, minJ];
            array[minI, minJ] = min;
        }
    }

}