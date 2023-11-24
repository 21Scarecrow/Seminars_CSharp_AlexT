/* 65. Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. */
Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void AllNaturalNumbers(int numb, int currentNumber)
{
    if (numb < currentNumber) return;
    else
    {
        System.Console.Write($"{currentNumber}" + " ");
        AllNaturalNumbers(numb, currentNumber + 1);
    }
}

int userM = Prompt("Enter the M number: ");
int userN = Prompt("Enter the N number: ");
AllNaturalNumbers(userN, userM);