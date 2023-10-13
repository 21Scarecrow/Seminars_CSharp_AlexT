// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    int res1 = number / 100 * 100;
    int result = (number - res1) / 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine($"Введенное число {number} не трехзначное");
}
// Как учесть отрицательные числа?