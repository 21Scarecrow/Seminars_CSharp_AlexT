// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();

System.Console.WriteLine("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber % 10;
System.Console.WriteLine(result);