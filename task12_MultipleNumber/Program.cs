// Написать программу, которая будет принимать на ввод 2 числа
// и проверять является ли второе число кратным первому. Если второе число
// не кратно первому, то программа выводит остаток от деления

System.Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber % firstNumber == 0)
{
    System.Console.WriteLine($"Число {secondNumber} кратно {firstNumber}");
}
else
{
    int rem = secondNumber % firstNumber;
    System.Console.WriteLine($"Остаток от деления равен {rem}");
}