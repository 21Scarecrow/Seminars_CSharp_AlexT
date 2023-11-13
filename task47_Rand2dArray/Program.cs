/*47. Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами. */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(double[,] matr)
{
    System.Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] matr = new double[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minLimitRandom, maxLimitRandom + 1) + new Random().NextDouble();
            //matr[i, j] = Math.Round(new Random().NextDouble() * (maxLimitRandom + 0.01 - minLimitRandom) + minLimitRandom, 2);
        }
    }
    return matr;
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int minLimitRandom = Prompt("Enter the minLimit: ");
int maxLimitRandom = Prompt("Enter the maxLimit: ");
double[,] userArray = CreateRandomMatrix(mRow, nCol, minLimitRandom, maxLimitRandom);
PrintArray(userArray);