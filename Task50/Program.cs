/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] InitArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int z = 0; z < row; z++)
    {
        for (int y = 0; y < column; y++)
        {
            array[z, y] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int z = 0; z < array.GetLength(0); z++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            System.Console.Write($"{array[y, z]} ");
        }
        System.Console.WriteLine();
    }
}

int FindElement(int[,] array)
{
    int count = 0;
    int targetElement = int.Parse(Console.ReadLine());
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int z = 0; z < array.GetLength(1); z++)
        {
            if (array[y, z] == targetElement)
                count++;
        }
    }
    if (count > 0)
        System.Console.WriteLine($"{targetElement} -> такое число в массиве есть");
    else System.Console.WriteLine($"{targetElement} -> такого числа в массиве нет");
    return targetElement;
}

System.Console.Write("Задайте количество строк в двумерном массиве: ");
int row = int.Parse(Console.ReadLine());
System.Console.Write("Задайте количество столбцов в двумерном массиве: ");
int column = int.Parse(Console.ReadLine());
int[,] array = InitArray(row, column);
PrintArray(array);
System.Console.Write("Введите значение элемента: ");

FindElement(array);


