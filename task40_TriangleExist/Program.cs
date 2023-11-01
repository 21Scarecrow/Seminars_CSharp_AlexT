/* 40. Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины. */

 Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void ExistTriangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
    System.Console.WriteLine("Такой треугольник может существовать");
    else
    System.Console.WriteLine("Такой треугольник не может существовать");
}
/* bool ExistTriangle(int a, int b, int c)
{
    bool result = false;
    if(a + b > c && b + c > a && c + a > b)
    result = true;
    return result;
} */

int sideA = Prompt("Enter the length of side A: ");
int sideB = Prompt("Enter the length of side B: ");
int sideC = Prompt("Enter the length of side C: ");

ExistTriangle(sideA, sideB, sideC);

//System.Console.WriteLine(ExistTriangle(sideA, sideB, sideC));

/* Еще интересный способ
Console.WriteLine("Введите длины трех сторон треугольника:");
Console.Write("Сторона A: ");
double sideA = double.Parse(Console.ReadLine());

Console.Write("Сторона B: ");
double sideB = double.Parse(Console.ReadLine());

Console.Write("Сторона C: ");
double sideC = double.Parse(Console.ReadLine());

bool isTriangle = IsTriangle(sideA, sideB, sideC);
{
if (isTriangle)
{
Console.WriteLine("Треугольник с такими сторонами существует.");
}
else
{
Console.WriteLine("Треугольник с такими сторонами не существует.");
}
}
bool IsTriangle(double a, double b, double c)
{
return a + b > c && a + c > b && b + c > a;
} */