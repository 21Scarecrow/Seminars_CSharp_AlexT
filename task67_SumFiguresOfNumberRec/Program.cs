/* 67. Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр. */

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int SumFiguresOfNumber(int numb)
{
    if (numb % 10 > 0)
    return numb % 10 + SumFiguresOfNumber(numb / 10);
    else
    return 0;

}

int userN = Prompt("Enter the N number: ");
int result = SumFiguresOfNumber(userN);
System.Console.WriteLine($"Сумма цифр в числе равна {result}");