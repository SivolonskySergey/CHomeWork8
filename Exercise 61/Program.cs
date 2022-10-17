using MyLibrary;

void MatrixMultiplication()
{
    Random random = new Random();
    int FirstRows = random.Next(4, 8);
    int FirstCols = random.Next(4, 8);
    int SecondRows = FirstCols;
    int SecondCols = random.Next(4, 8);

    int[,] firstMatrix = new int[FirstRows, FirstCols];
    int[,] secondMatrix = new int[SecondRows, SecondCols];

    ArraysMethods.FillMultiArray(firstMatrix, 0, 5);
    ArraysMethods.PrintMultiArray(firstMatrix);
    Console.WriteLine();
    ArraysMethods.FillMultiArray(secondMatrix, 0, 5);
    ArraysMethods.PrintMultiArray(secondMatrix);

    int[,] result = new int[FirstRows, SecondCols];

    for (int i = 0; i < FirstRows; i++)
    {
        for (int j= 0; j < SecondCols; j++)
        {
            for (int k = 0; k < SecondRows; k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k,j];
            }
        }
    }
    Console.WriteLine();
    ArraysMethods.PrintMultiArray(result);
}

MatrixMultiplication();