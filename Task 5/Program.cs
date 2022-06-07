/*
Заполните спирально массив 4 на 4.
1   2   3   4

12  13  14  5

11  16  15  6

10  9   8   7
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
        }
}

int[,] FillArray(int rows, int columns)
{
int s = 1;
int x = 1;
int y = 1;
int [,] array = new int [rows, columns];
for(int j = 0; j < columns; j++)
{
    array[0, j] = s;
    s++;
}
for(int i = 1; i < rows; i++)
{
    array[i, columns - 1] = s;
    s++;
}
for(int j = columns - 2; j>= 0; j--)
{
    array[rows - 1, j] = s;
    s++;
}
for(int i = rows - 2; i > 0; i--)
{
    array[i, 0] = s;
    s++;
}

while (array[y, x+1] == 0)
{
    array[y,x] = s;
    s++;
    x++;
}
while (array[y + 1, x] == 0)
{
    array[y,x] = s;
    s++;
    y++;
}
while (array[y, x-1] == 0)
{
    array[y,x] = s;
    s++;
    x--;
}
while (array[y - 1, x] == 0)
{
    array[y,x] = s;
    s++;
    y--;
}
for(int i = 0; i<rows;i++)
    for(int j = 0; j < columns; j++)
    {
        if(array[i,j] == 0) array[i,j]=s;
    }
    return array;
}

int m = 4;
int n = 4;
int [,] arr = FillArray(m,n);
PrintArray(arr);
