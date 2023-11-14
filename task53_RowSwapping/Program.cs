/* 53. Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2   */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(int[,] matr)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + matr.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        System.Console.Write($"[" + i + "]\t");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] CreateRandomMatrix(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 21);
        }
    }
    return matr;
}
/* int[,] CopyArray (int[,] array)
{
    int[,] result = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array [i,j];
        }
    }
    return result;
} */
int[,] SwappingFirstLastRow(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
}
Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol);
PrintArray(userArray);
System.Console.WriteLine();
int[,] arraySwap = SwappingFirstLastRow(userArray);
PrintArray(arraySwap);