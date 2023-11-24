/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumMtoN(int numbA, int numbB)
{
    if( numbA > numbB) return 0;
    else
    return numbA + SumMtoN(numbA + 1, numbB);
}   

int userM = Prompt("Enter the M number: ");
int userN = Prompt("Enter the N number: ");
int result = SumMtoN(userM, userN);
System.Console.WriteLine($"Сумма равна {result}");