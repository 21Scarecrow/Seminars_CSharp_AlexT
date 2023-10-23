/*25. Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
double Pow(double num, int pow)
{
    double result = 1;

    if (pow > 0)
    {
        for (int i = 1; i <= pow; i++)
        {
            result *= num;
        }
    }
    else if (pow < 0)
    {
        for (int i = -1; i >= pow; i--)
        {
            result /= num;
        }
    }

    return result;
}
Console.Clear();
System.Console.WriteLine("Enter the number A: ");
double userA = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter the power B: ");
int userB = Convert.ToInt32(Console.ReadLine());

double result = Pow(userA, userB);
System.Console.WriteLine($"Число {userA} в степени {userB} равно {result}");