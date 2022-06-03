/*
Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int GetDimension(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int firstDimension, int secondDimension)
{
    int[,] array = new int[firstDimension, secondDimension];
    Random rnd = new Random();
    for (int i = 0; i < firstDimension; i++)
        for (int j = 0; j < secondDimension; j++)
            array[i, j] = rnd.Next(-99, 100);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
        }
}

int m = GetDimension("Введите количество строк массива: ");
int n = GetDimension("Введите количество столбцов массива: ");
int [,] arr = FillArray(m, n);
PrintArray(arr);