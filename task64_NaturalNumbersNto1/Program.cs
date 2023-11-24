/* Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void AllNaturalNumbers(int numb)
{
    if (numb == 0) return;
    else
    {
        System.Console.Write($"{numb}" + " ");
        AllNaturalNumbers(numb - 1);
    }
}

int userN = Prompt("Enter the N number: ");
AllNaturalNumbers(userN);