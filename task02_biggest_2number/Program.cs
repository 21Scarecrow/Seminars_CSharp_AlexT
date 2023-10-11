// Найти большее из 2х чисел

System.Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
}
else if(secondNumber < firstNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
else if(firstNumber == secondNumber)
{
    System.Console.WriteLine($"Введенные числа равны {firstNumber}");
}