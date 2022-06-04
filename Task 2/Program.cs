/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

(int, int) GetDimensions(string message1, string message2)
{
    Console.WriteLine(message1);
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine(message2);
    int columns = int.Parse(Console.ReadLine());
    while (columns <= rows)
    {
        Console.WriteLine(message2);
        columns = int.Parse(Console.ReadLine());
    }
    return (rows, columns);

}
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = rnd.Next(-99, 100);
    }
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

void FindRowOfMinimumSum(int[,] array)
{
    int [] rowSum = new int [array.GetLength(0)];
    int min = rowSum[0];
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            summ += array[i, j];
        rowSum [i] = summ;
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        if(rowSum[i] < min) 
        {
            min = rowSum[i];
            minIndex = i;
        }
    }
    Console.WriteLine($" Cтрока {minIndex + 1} имеет наименьшую сумму элементов равную {min} ");
}
(int m, int n) = GetDimensions("Введите число строк массива: ", "Введите число столбцов массива, большее числа строк: ");
int[,] arr = FillArray(m, n);
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
FindRowOfMinimumSum(arr);

