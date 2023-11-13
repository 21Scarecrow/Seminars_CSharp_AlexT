/*50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или 
 же указание, что такого элемента нет.*/
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

string FindElement(int[,] matr, int a, int b)
{
    string result = "";
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(a >= matr.GetLength(0) || b >= matr.GetLength(1))
            result = "Такого элемента нет";
            else
            result = Convert.ToString(matr[a, b]);
        }
    }
    return result;
}

Console.Clear();

int mRow = Prompt("Enter the raw: ");
int nCol = Prompt("Enter the calumn: ");
int indRow = Prompt("Enter the row position: ");
int indCol = Prompt("Enter the column position: ");
int[,] userArray = CreateRandomMatrix(mRow, nCol);
PrintArray(userArray);
System.Console.WriteLine();
string result = FindElement(userArray, indRow, indCol);
System.Console.WriteLine($"Искомый элемент: {result}");