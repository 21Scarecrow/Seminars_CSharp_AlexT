/* 27. Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

void FindSumFigure(int arg)
{
    int sum = 0;
    for (int i = arg; i > 0; i /= 10)
    {
        sum = sum % 10 + i;
    }
    System.Console.WriteLine($"Сумма цифр в заданном числе равна {sum}");
}

System.Console.WriteLine("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

FindSumFigure(userNumber);