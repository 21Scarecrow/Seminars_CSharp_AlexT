//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();

System.Console.WriteLine("Введите номер дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 1)
{
    System.Console.WriteLine("Понедельник");
}

if(userNumber == 2)
{
    System.Console.WriteLine("Вторник");
}

if(userNumber == 3)
{
    System.Console.WriteLine("Среда");
}

if(userNumber == 4)
{
    System.Console.WriteLine("Четверг");
}

if(userNumber == 5)
{
    System.Console.WriteLine("Пятница");
}

if(userNumber == 6)
{
    System.Console.WriteLine("Суббота");
}

if(userNumber == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
System.Console.WriteLine("Нет такого дня недели");
}