/*55. Задайте двумерный массив. Напишите программу, которая заменяет 
строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/
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

int[,] SwappingRowsColumns(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (i != j)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
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
int[,] arraySwap = SwappingRowsColumns(userArray);
if (mRow != nCol) System.Console.WriteLine("Задача не выполнима");
else PrintArray(arraySwap);
/*
int Prompt(string massage)
{
System.Console.Write(massage);
Console.ForegroundColor = ConsoleColor.DarkGreen;
int result = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
return result;
}

int[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
{
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrixOne, int[,] matrixTwo)
{
System.Console.WriteLine("\nДвумерный массив:");
for (int i = 0; i < matrixOne.GetLength(0); i++)
{
for (int j = 0; j < matrixOne.GetLength(1); j++)
{
Console.ForegroundColor = ConsoleColor.DarkBlue;
System.Console.Write(matrixOne[i, j]);
if (j < matrixOne.GetLength(1) - 1)
System.Console.Write("\t");
else System.Console.WriteLine();
Console.ResetColor();
}
}
System.Console.WriteLine("\nНовый массив:");
for (int i = 0; i < matrixTwo.GetLength(0); i++)
{
for (int j = 0; j < matrixTwo.GetLength(1); j++)
{
Console.ForegroundColor = ConsoleColor.Cyan;
System.Console.Write(matrixTwo[i, j]);
if (j < matrixTwo.GetLength(1) - 1)
System.Console.Write("\t");
else System.Console.WriteLine();
Console.ResetColor();
}
}
}

int[,] ConvertMatrix(int[,] matrixOne)
{
int[,] matrixTwo = new int[matrixOne.GetLength(1), matrixOne.GetLength(0)];
for (int i = 0; i < matrixTwo.GetLength(0); i++)
{
for (int j = 0; j < matrixTwo.GetLength(1); j++)
{
matrixTwo[i, j] = matrixOne[j, i];
}
}
return matrixTwo;
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix, ConvertMatrix(matrix)); */