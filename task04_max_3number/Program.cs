// Максимальное из 3х чисел

//Вводим метод нахождения максимального из 3х чисел
int FindMax(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

System.Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = FindMax(firstNumber, secondNumber, thirdNumber);
System.Console.WriteLine(max + " is max number");