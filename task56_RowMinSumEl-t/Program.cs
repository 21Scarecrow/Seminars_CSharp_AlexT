/* 56:Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
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

int[,] CreateRandomMatrix(int m)
{
    int[,] matr = new int[m, m];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 11);
        }
    }
    return matr;
}

int FindRowWithMinSum(int[,] array)
{
    int minSumRow = 0;
    int minSum = int.MaxValue;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }
        
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }
    
    return minSumRow;
}

int[] GetRow(int[,] matrix, int rowIndex)
{
    int rowLength = matrix.GetLength(1);
    int[] row = new int[rowLength];

    for (int i = 0; i < rowLength; i++)
    {
        row[i] = matrix[rowIndex, i];
    }

    return row;
}

Console.Clear();

int mRow = Prompt("Введите количество строк и столбцов: ");
int[,] matrix = CreateRandomMatrix(mRow);
Print2dArray(matrix);
Console.WriteLine();
int minSumRowIndex = FindRowWithMinSum(matrix);
int[] minSumRow = GetRow(matrix, minSumRowIndex);
PrintArray(minSumRow);

