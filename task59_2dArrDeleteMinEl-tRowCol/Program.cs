/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7 */

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
            matr[i, j] = new Random().Next(0, 31);
        }
    }
    return matr;
}
static (int, int) FindMinElementIndices(int[,] matrix)
{
    int minRow = 0, minCol = 0, minElement = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }

    return (minRow, minCol);
}
int[,] RemoveRowAndColumn(int[,] matrix, int rowToRemove, int colToRemove)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int[,] resultMatrix = new int[rows - 1, cols - 1];

    for (int i = 0, newRow = 0; i < rows; i++)
    {
        if (i == rowToRemove)
            continue;

        for (int j = 0, newCol = 0; j < cols; j++)
        {
            if (j != colToRemove)
            {
                resultMatrix[newRow, newCol] = matrix[i, j];
                newCol++;
            }
        }

        newRow++;
    }

    return resultMatrix;
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol);

Console.WriteLine("Исходный массив:");
PrintArray(userArray);

(int minRow, int minCol) = FindMinElementIndices(userArray);

int[,] resultArray = RemoveRowAndColumn(userArray, minRow, minCol);

Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
PrintArray(resultArray);