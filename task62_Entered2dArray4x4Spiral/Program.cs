/* Заполните спирально массив 4 на 4.
1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7 */

int[,] FillSpiralArray(int size)
{
    int[,] array = new int[size, size];

    int value = 1;
    int startRow = 0, endRow = size - 1, startCol = 0, endCol = size - 1;

    while (value <= size * size)
    {
        // Вправо
        for (int col = startCol; col <= endCol; col++)
        {
            array[startRow, col] = value++;
        }
        startRow++;

        // Вниз
        for (int row = startRow; row <= endRow; row++)
        {
            array[row, endCol] = value++;
        }
        endCol--;

        // Влево
        for (int col = endCol; col >= startCol; col--)
        {
            array[endRow, col] = value++;
        }
        endRow--;

        // Вверх
        for (int row = endRow; row >= startRow; row--)
        {
            array[row, startCol] = value++;
        }
        startCol++;
    }

    return array;
}

void Print2dArray(int[,] matr)
{
    Console.Write($"[{new string(' ', 2)}]\t");

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Console.Write($"[{i.ToString().PadLeft(2)}]\t");
    }

    Console.WriteLine();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"[{i.ToString().PadLeft(2)}]\t");

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j].ToString().PadLeft(2)}\t");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] spiralArray = FillSpiralArray(4);

Print2dArray(spiralArray);
System.Console.WriteLine();
System.Console.WriteLine("Press any key...");
Console.ReadKey();
