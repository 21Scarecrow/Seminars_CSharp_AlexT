// Вывести четные числа

//Используем метод void, т.к. нам не нужно возвращать значения
void PrintEvenNumbers(int number)
{
    for (int res = 2; res <= number; res = res + 2)
    {
        System.Console.Write(res + "\t");
    }

}

System.Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

PrintEvenNumbers(userNumber);