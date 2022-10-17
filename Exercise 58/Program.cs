// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using MyLibrary;

int rows = 4;
int cols = 4;
int[,] numbers = new int[rows, cols];

void FillArraySpiral(int[,] arr)
{
    int index = 0;
    int currentRow = 0;
    int currentCol = 0;

    int changeIndexRow = 0;
    int changeIndexCols = 1;
    
    int steps = cols;
    int turn = 0;

    while(index < numbers.Length)
    {
        arr[currentRow, currentCol] = index + 1;
        //Console.Write(arr[currentRow, currentCol] + " ");
        index++;
        steps--;
        if(steps == 0)
        {
            steps = cols - 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexCols;
            changeIndexCols = -temp;
            turn++;
        }

        currentRow += changeIndexRow;
        currentCol += changeIndexCols;
    }
    ArraysMethods.PrintMultiArray(arr);
}

FillArraySpiral(numbers);