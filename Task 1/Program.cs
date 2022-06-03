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

void SortRowsToMinimum (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            int temp = 0;
            int length = array.GetLength(1) - 1;
            while(length > 0)
            {
                for(int j = 0; j < length; j++)
                {
                    if(array[i, j] < array[i,j+1])
                    {
                        temp = array[i, j];
                        array[i,j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }
                }
                length--;          

            }
        }
}

int m = GetDimension("Введите количество строк массива: ");
int n = GetDimension("Введите количество столбцов массива: ");
int [,] arr = FillArray(m, n);
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
Console.WriteLine();
SortRowsToMinimum(arr);
PrintArray(arr);