// /*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// */



class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер строк матрицы:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер столбцов матрицы:");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            Random rand = new Random();
            int[] summ = new int[M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(0, 10); //рандомные значения для елементов матрицы
                    
                }
            }
            Console.WriteLine("Матрица");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                  
                    Console.Write($"{matrix[i, j]} "); //вывод матрицы
                    summ[i] += matrix[j, i];      //подсчет суммы колонки
                } 
                Console.WriteLine();
            }
            Console.WriteLine();
            System.Console.Write("Среднее арифметическое каждого столбца: ");
            foreach (double elem in summ)
            {
                
                Console.Write($"{elem/M}; "); //вывод среднего для колонки
            }
 
        }
    }