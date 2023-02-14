// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);
double[,] numbers = new double[row, col];
GetArray(numbers);
PrintArray(numbers);