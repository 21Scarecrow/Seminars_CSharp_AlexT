/* 26. Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
void CountFigure(int arg)
{
    int count = 0;
    for (int i = arg; i > 0; i /= 10)
    {
        count = count + 1;
    }
    System.Console.WriteLine(count);
}
Console.Clear();
System.Console.WriteLine("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

CountFigure(userNumber);