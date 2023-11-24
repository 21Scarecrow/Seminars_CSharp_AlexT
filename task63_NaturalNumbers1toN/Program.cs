/* 63. Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N. */
Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void AllNaturalNumbers(int numb, int currentNumber = 1)
{
    if (numb < currentNumber) return;
    else
    {
        System.Console.Write($"{currentNumber}" + " ");
        AllNaturalNumbers(numb, currentNumber + 1);
    }
}

int userN = Prompt("Enter the N number: ");
AllNaturalNumbers(userN);