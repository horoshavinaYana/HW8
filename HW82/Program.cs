// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int col, int row)
{
    return new int[row, col];
}

void Fill2DArray(int[,] array2D, int low, int high)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(low, high);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    int LastCol = array2D.GetLength(1);
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < LastCol; j++)
        {
            if (j == LastCol - 1)
            {
                Console.Write(array2D[i, j]);
            }
            else
            {
                Console.Write($"{array2D[i, j]};");
            }
        }
        Console.WriteLine();
    }
}

int GetRowMinSumm(int[,] array2D)
{
    int SummRow;
    int MinSumm = int.MaxValue;
    int MinRow = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        SummRow = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            SummRow = SummRow + array2D[i, j];
        }
        if (SummRow <= MinSumm)
        {
            MinSumm = SummRow;
            MinRow = i;
        }
    }
    return MinRow + 1;
}

int col = GetIncomingData("Введите количество столбцов");
int row = GetIncomingData("Введите количество строк");
int[,] arr2D = Create2DArray(col, row);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
Fill2DArray(arr2D, low, high);
Print2DArray(arr2D);
Console.WriteLine($"{GetRowMinSumm(arr2D)} строка");