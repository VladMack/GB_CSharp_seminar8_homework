Console.Clear();

Console.WriteLine("Введи высоту и ширину массивов через пробел:");
int[] lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = lenghts[0];
int n = lenghts[1];
Console.WriteLine();

int[,] numbers1 = GetArray(m, n, 0, 9);
int[,] numbers2 = GetArray(m, n, 0, 9);
PrintArray(numbers1);
Console.WriteLine();
PrintArray(numbers2);
Console.WriteLine();
int[,] numbers3 = Mult2Arrays(numbers1, numbers2);
PrintArray(numbers3);


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

int[,] Mult2Arrays(int[,] array1, int[,] array2)
{
    int[,] MultArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            MultArray[i, j] = array1[i, j] * array2[i, j];
        }

    }
    return MultArray;
}