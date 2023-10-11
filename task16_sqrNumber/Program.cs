// Напишите программу, которая принимает на вход 2 числа и проверяет,
// является ли одно число квадратом другого

System.Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2 || num2 == num1 * num1)
{
System.Console.WriteLine("Одно число является квадратом второго");
}
else{
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");
}