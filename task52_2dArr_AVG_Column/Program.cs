/*52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double[] FindAVG(int[,] matr)
{
    double sum = 0;
    double[] avg = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        avg[j] = sum / matr.GetLength(0);
    }
    return avg;
}
void PrintAVG(double[] array)
{
    Console.WriteLine("The averages in columns are:");
    foreach (double el in array)
    {
        Console.Write($"{el:f2}" + "\t");

    }
    Console.WriteLine();
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol);
PrintArray(userArray);
System.Console.WriteLine();
double[] columnAvg = FindAVG(userArray);
PrintAVG(columnAvg);