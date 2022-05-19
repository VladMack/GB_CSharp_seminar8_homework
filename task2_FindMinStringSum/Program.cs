Console.Clear();

Console.WriteLine("Введи высоту и ширину массива через пробел:");
int[] lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = lenghts[0];
int n = lenghts[1];
Console.WriteLine();

int[,] numbers = GetArray(m, n, 0, 9);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке {GetMin(GetSum(numbers))}.");
Console.WriteLine();


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

int[] GetSum(int[,] arr)
{
    int k = 0;
    int[] newArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[k] += arr[i, j];
        }
        k++;
    }
    return newArray;
}

int GetMin(int[] arr)
{
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex]) minIndex = i;
    }
    return minIndex + 1;
}