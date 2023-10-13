//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

System.Console.WriteLine("Введите номер дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == 1)
{
    System.Console.WriteLine("Понедельник - не выходной день");
}

if (userNumber == 2)
{
    System.Console.WriteLine("Вторник - не выходной день");
}

if (userNumber == 3)
{
    System.Console.WriteLine("Среда - не выходной день");
}

if (userNumber == 4)
{
    System.Console.WriteLine("Четверг - не выходной день");
}

if (userNumber == 5)
{
    System.Console.WriteLine("Пятница - не выходной день");
}

if (userNumber == 6)
{
    System.Console.WriteLine("Суббота - выходной день");
}

if (userNumber == 7)
{
    System.Console.WriteLine("Воскресенье - выходной день");
}
if (userNumber < 1 || userNumber > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}