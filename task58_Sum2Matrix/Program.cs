/* 58:Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц. */
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
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

int[,] CreateRandomMatrix(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
        }
    }
    return matr;
}
int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    if (colsA != rowsB)
    {
        Console.WriteLine("Невозможно выполнить умножение матриц. Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        return null;
    }

    
    int[,] resultMatrix = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;

            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }

            resultMatrix[i, j] = sum;
        }
    }
    
    return resultMatrix;
}
Console.Clear();

int rowsA = Prompt("Enter the raws matrix A: ");
int colsA = Prompt("Enter the calumns matrix A: ");
int rowsB = Prompt("Enter the raws matrix B: ");
int colsB = Prompt("Enter the calumns matrix B: ");

int[,] matrixA = CreateRandomMatrix(rowsA, colsA);
Print2dArray(matrixA);
System.Console.WriteLine();
int[,] matrixB = CreateRandomMatrix(rowsB, colsB);
Print2dArray(matrixB);
int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);
Print2dArray(resultMatrix);
if(colsA != rowsB)
System.Console.WriteLine("Невозможно выполнить умножение");
