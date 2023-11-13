/* 51. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(int[,] matr)
{
    System.Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
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
void FindSumDiagElements(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        result = result + matr[i, i];
    }
    System.Console.WriteLine($"Сумма элементов главной диагонали: {result}");
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int minLimitRandom = Prompt("Enter the minLimit: ");
int maxLimitRandom = Prompt("Enter the maxLimit: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol, minLimitRandom, maxLimitRandom);
PrintArray(userArray);
FindSumDiagElements(userArray);
