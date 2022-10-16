
using MyLibrary;

Random random = new Random();
int rowsAmount = random.Next(4, 10);
int colsAmount = random.Next(5, 5);
int[,] numbers = new int[rowsAmount, colsAmount];

void FindMinSum(int[,] arr)
{
    ArraysMethods.FillMultiArray(numbers, 0, 10);
    ArraysMethods.PrintMultiArray(numbers);
    Console.WriteLine();

    int sumMin = 0;
    int sum = 0;
    int currentRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"сумма строки {i} - {sum}");
        if (sum < sumMin || sumMin == 0)
        {
            sumMin = sum;
            currentRow = i;
        }
        sum = 0;
    }
    Console.Write($"Наименьшая сумма элементов '{sumMin}' - строка {currentRow}");
    Console.WriteLine();
}

FindMinSum(numbers);