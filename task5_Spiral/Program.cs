Console.Clear();

Console.WriteLine("Введи высоту и ширину квадратного массива пробел:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] numbers = GetSpiralSquareArray(n, n);
PrintArray(numbers);
Console.WriteLine();


int[,] GetSpiralSquareArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int value = 1, i = 0, j = 0, startStopCounter = 0;
    while (value <= rows * columns)
    {
        for (i = startStopCounter; i <= startStopCounter; i++)
        {
            for (j = startStopCounter; j < result.GetLength(1) - startStopCounter; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        for (i = startStopCounter + 1; i < result.GetLength(0) - startStopCounter; i++)
        {
            for (j = result.GetLength(1) - 1 - startStopCounter; j < result.GetLength(1) - startStopCounter; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        for (i = result.GetLength(0) - 1 - startStopCounter; i >= result.GetLength(1) - 1 - startStopCounter; i--)
        {
            for (j = result.GetLength(1) - 2 - startStopCounter; j >= startStopCounter; j--)
            {
                result[i, j] = value;
                value++;
            }
        }
        for (i = result.GetLength(0) - 2 - startStopCounter; i > startStopCounter; i--)
        {
            for (j = startStopCounter; j <= startStopCounter; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        startStopCounter++;
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