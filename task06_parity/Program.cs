// Проверка на четность

//Используем метод void, т.к нам не нужно возвращать значения
void CheckIfEven(int number)
{
    if(number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} чётное");
}
else
{
    System.Console.WriteLine($"Число {number} нечётное");
}
}

System.Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

CheckIfEven(userNumber);