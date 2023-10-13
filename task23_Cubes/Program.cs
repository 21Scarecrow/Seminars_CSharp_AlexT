// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
System.Console.Write("Enter number: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
    System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}