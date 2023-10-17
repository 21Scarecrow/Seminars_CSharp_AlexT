/*28. Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/
void Factorial(int arg)
{
    int fact = 1;
    for (int i = 1; i <= arg; i++)
    {
        fact = fact * i;
    }
    System.Console.WriteLine(fact);
}
System.Console.WriteLine("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Factorial(userNumber);