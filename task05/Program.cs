// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();


System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for(int i = -userNumber; i <= userNumber; i++)
{
    System.Console.Write(i + " ");
}