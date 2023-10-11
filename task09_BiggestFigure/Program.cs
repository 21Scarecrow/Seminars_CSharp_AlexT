// Написать программу, которая выводит случайное двухзначное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);

System.Console.WriteLine(number);
System.Console.WriteLine();
int first = number / 10;
int last = number % 10;
if (first > last)
{
    System.Console.WriteLine("Max is " + first);
}
else
{
    System.Console.WriteLine("Max is " + last);
}

