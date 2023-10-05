//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();

System.Console.WriteLine("Введите число 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}