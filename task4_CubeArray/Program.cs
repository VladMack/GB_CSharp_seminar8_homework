Console.Clear();

Console.WriteLine("Введи высоту, ширину и глубину массива через пробел:");
int[] lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = lenghts[0];
int n = lenghts[1];
int o = lenghts[2];
Console.WriteLine();
Console.WriteLine("Введи минимальное и максимальное значения через пробел:");
int[] minMaxValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int minValue = minMaxValues[0];
int maxValue = minMaxValues[1];
Console.WriteLine();
List<int> usedValues = new List<int>();

if (m * n * o > maxValue - minValue)
{
    Console.WriteLine("Диапазон значений меньше количества элементов. Сформировать массив с неповторяющимися значениями невозможно.");
    Console.WriteLine();
}
else
{
    int[,,] numbers = GetArray(m, n, o, minValue, maxValue);
    PrintArray(numbers);
}


int[,,] GetArray(int rows, int columns, int depths, int min, int max)
{
    int[,,] result = new int[rows, columns, depths];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                result[i, j, k] = GetUniqueNumber(min, max);

            }

        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }

}

int GetUniqueNumber(int min, int max)
{
    while (true)
    {
        var n = new Random().Next(min, max + 1);
        if (!usedValues.Contains(n))
        {
            usedValues.Add(n);
            return n;
        }
    }
}