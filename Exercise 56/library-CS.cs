namespace MyLibrary
{
    class ArraysMethods
    {

        // ---------- ДЛИННА ЧИСЛА ---------------

        public static int GetLength(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count += 1;
            }
            return count;
        }

        // ---------- ПЕЧАТЬ ОДНОМЕРНОГО МАССИВА ---------------

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        // ---------- ПЕЧАТЬ МНОГОМЕРНОГО МАССИВА ---------------

        public static void PrintMultiArray(int[,] numbers)
        {
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // ---------- ЗАПОЛНЕНИЕ ОДНОМЕРНОГО МАССИВА ---------------

        public static void FillArray(int[] arr, int minValue, int maxValue)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }
        }

        // ---------- ЗАПОЛНЕНИЕ МНОГОМЕРНОГО МАССИВА ---------------

        public static void FillMultiArray(int[,] arr, int minValue, int maxValue)
        {
            maxValue++;
            Random random = new Random();
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        // ---------- СОРТИРОВКА МАССИВА ---------------

        public static void GetSorted(int[] array)
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Math.Abs(array[i]) < Math.Abs(array[j])) 
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    Console.Write($"[{i}] < [{j}]");
                    Console.WriteLine();
                }
            }
        }
    }
}