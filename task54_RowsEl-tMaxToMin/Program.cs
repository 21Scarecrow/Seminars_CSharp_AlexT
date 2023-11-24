/*  54:Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива. */
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
int[,] SortMaxToMinElementsRows(int[,] array)
{

    for (int k = 0; k < array.GetLength(1); k++)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}
    Console.Clear();

    int mRow = Prompt("Enter the raw: ");
    int nCol = Prompt("Enter the calumn: ");
    int[,] userArray = CreateRandomMatrix(mRow, nCol);
    PrintArray(userArray);
    System.Console.WriteLine();
    int[,] arraySort = SortMaxToMinElementsRows(userArray);
    PrintArray(arraySort);