/* 69. Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии. */

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int APowB(int numbA, int numbB)
{
    if( numbB == 1) return numbA;
    else
    return numbA * APowB(numbA, numbB - 1);
}

int userA = Prompt("Enter the A number: ");
int userB = Prompt("Enter the B number: ");
int result = APowB(userA, userB);
System.Console.WriteLine($"A в степени B равно {result}");
