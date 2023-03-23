// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

static void FindElementByIndex(int m, int n)
        {
            int[,] arr = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите позиции элемента в массиве");
            Console.Write("i: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("j: ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Искомый элемент = " + arr[k1, k2]);
        }

Console.Write("Введите количество строк: "); 
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: "); 
int N = Convert.ToInt32(Console.ReadLine());

FindElementByIndex(M, N);