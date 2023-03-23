//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double FillArray(int m, int n) 
{
    double[,] array = new double[m, n];
 
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.NextDouble()*100;
                    Console.Write("{0,6:F2}", array[i, j]);
                }
                Console.WriteLine();
            }
    return 0;
}

Console.WriteLine("Введите количество строк: "); 
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: "); 
int N = Convert.ToInt32(Console.ReadLine());

FillArray(M, N);