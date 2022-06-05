/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int GetDimension(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,,] FillArray(int firstDimension, int secondDimension, int thirdDimension)
{
    int[,,] array = new int[firstDimension, secondDimension, thirdDimension];
    int num = 9;
    for (int i = 0; i < firstDimension; i++)
        for (int j = 0; j < secondDimension; j++)
            for (int e = 0; e < thirdDimension; e++)
            {
                num++;
                array[i, j, e] = num;
            }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < array.GetLength(2); e++)
                Console.Write($"{array[i, j, e]}[{i},{j},{e}] ");
            Console.WriteLine();
        }
        Console.WriteLine();  

    }
        
}

int m = GetDimension("Введите первый размер массива: ");
int n = GetDimension("Введите второй размер массива: ");
int k = GetDimension("Введите третий размер массива: ");
int[,,] arr = FillArray(m, n, k);
Console.WriteLine("Построчный вывод элементов массива с индексами: ");
PrintArray(arr);
