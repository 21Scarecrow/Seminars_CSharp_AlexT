// Программа генерирует случайное трехзначное число и удаляет вторую цифру

int number = new Random().Next(100, 1000);

System.Console.WriteLine(number);
System.Console.WriteLine();

int first = number / 100;
int last = number % 10;

System.Console.WriteLine($"{first}{last}");