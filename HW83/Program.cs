// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


int[,,] Create3DArray(int x, int y, int z)
{
    return new int[x, y, z];
}

void Fill3DArray(int[,,] array3D)
{
    int Iter = 10;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Iter++;
                array3D[x, y, z] = Iter;
            }
        }
    }
}

void Print3DArray(int[,,] array3D)
{
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[x, y, z]}({x},{y},{z})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr3D = Create3DArray(2, 2, 2);
Fill3DArray(arr3D);
Print3DArray(arr3D);