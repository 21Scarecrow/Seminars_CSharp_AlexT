/* 49. Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты. */

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
int[,] CreateNewArray (int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            matr[i, j] = matr[i, j] * matr[i, j];
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
int[,] newUserArray = CreateNewArray(userArray);
PrintArray(newUserArray);