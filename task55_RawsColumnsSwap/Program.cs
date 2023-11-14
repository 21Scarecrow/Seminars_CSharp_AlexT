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