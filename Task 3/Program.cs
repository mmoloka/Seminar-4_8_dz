/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
(int, int) GetDimensions(string message1, string message2)
{
    Console.WriteLine(message1);
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine(message2);
    int columns = int.Parse(Console.ReadLine());
    return (rows, columns);
}
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = rnd.Next(-9, 10);
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

int[,] MultyplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < matrixA.GetLength(1); n++)
                sum += (matrixA[i, n] * matrixB[n, j]);
            matrixC[i, j] = sum;
        }
    }
    return matrixC;
}

(int m, int n) = GetDimensions("Введите число строк матрицы A: ", "Введите число столбцов матрицы A: ");
Console.WriteLine("Число строк матрицы B равно числу столбцов матрицы A по правилу умножения матриц. ");
Console.WriteLine("Ведите число столбцов матрицы B: ");
int k = int.Parse(Console.ReadLine());

int[,] arrA = FillArray(m, n);
int[,] arrB = FillArray(n, k);
int[,] arrC = MultyplyMatrix(arrA, arrB);
Console.WriteLine("Матрица A: ");
PrintArray(arrA);
Console.WriteLine("Матрица B: ");
PrintArray(arrB);
Console.WriteLine("Матрица C равная произведению матриц A и B: ");
PrintArray(arrC);

