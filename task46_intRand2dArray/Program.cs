/* 46. Задайте двумерный массив размером m×n, заполненный
 случайными целыми числами. */

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

int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minLimitRandom, maxLimitRandom + 1);
        }
    }
    return matr;
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int minLimitRandom = Prompt("Enter the minLimit: ");
int maxLimitRandom = Prompt("Enter the maxLimit: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol, minLimitRandom, maxLimitRandom);
PrintArray(userArray);