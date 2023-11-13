/* Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Prompt(string message)
{
    System.Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}
void CrossPointLine(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    if (k1 == k2) System.Console.WriteLine("Прямые не пересекаются");
    else System.Console.WriteLine($"\nТочка пересечения прямых: [{x}; {y}]");
}
Console.Clear();
double k1Number = Prompt("Enter the k1: ");
double b1Number = Prompt("Enter the b1: ");
double k2Number = Prompt("Enter the k2: ");
double b2Number = Prompt("Enter the b2: ");

CrossPointLine(k1Number, b1Number, k2Number, b2Number);