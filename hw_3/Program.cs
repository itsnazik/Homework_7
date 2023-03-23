// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

static void ArithmeticAverage(int m, int n) 
{
    Random random = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
        {
        for (int j = 0; j < n; j++)
            {
            arr[i, j] = random.Next(1, 10);
            Console.Write(arr[i, j] + " ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += arr[i, j];
        }
    Console.Write($"{ sum / m} ");
    }
    Console.ReadLine();
}

Console.Write("Введите количество строк: "); 
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: "); 
int N = Convert.ToInt32(Console.ReadLine());

ArithmeticAverage(M, N);

