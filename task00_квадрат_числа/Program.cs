// Напишите программу, которая на вход принимает число и выдает его квадрат

Console.Clear();
System.Console.WriteLine("Введите число: "); // cw - быстрый вызов Console.WriteLine
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber * userNumber;
Console.WriteLine(result);
//Console.WriteLine(userNumber * userNumber);