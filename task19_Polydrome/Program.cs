// Принять на ввод 5-тизначное число и проверить полиндром ли оно
Console.Clear();
System.Console.Write("Enter number: ");
int userNumber = int.Parse(Console.ReadLine());
int difNumber = userNumber;
int polNumber = 0;

while (difNumber > 0)
{
  polNumber = polNumber * 10 + difNumber % 10;
  difNumber = difNumber / 10;
}
System.Console.WriteLine(polNumber);
if (userNumber == polNumber)
System.Console.WriteLine($"Число {userNumber} является полиндромом");
else
System.Console.WriteLine($"Число {userNumber} не является полиндромом");
