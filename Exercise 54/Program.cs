
using MyLibrary;

void SortRowsToMin()
{
    Random random = new Random();
    int rows = random.Next(3, 6);
    int cols = random.Next(3, 6);
    int[,] numbers = new int[rows, cols];
    ArraysMethods.FillMultiArray(numbers, -10, 10);
    ArraysMethods.PrintMultiArray(numbers);
    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++ )
        {
            int border = cols - j - 1;
            for(int k = 0; k < border; k++)
            {
                if(numbers[i, k] < numbers[i, k + 1])
                {
                    (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
                }
            }
        }
    }
    ArraysMethods.PrintMultiArray(numbers);
}

SortRowsToMin();