/* 33. Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да */

Console.Clear();
int[] GetRandArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");

    }
    System.Console.WriteLine("]");
}
void FindNumber(int[] array, int find)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
            count++;
    }
    if (count == 0)
        System.Console.WriteLine("Такого числа нет");
    else
        System.Console.WriteLine($"Содержит в количестве {count} штук");
}
/*bool FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
            return true;
    }
    return false;
} 
void PrintArray(int[] arr, bool a)
{

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");

    }
    System.Console.WriteLine("] -> ");
    if (a == true) System.Console.WriteLine("Да")
    else System.Console.WriteLine("Нет")
}
*/ // Решение через bool

System.Console.WriteLine("Enter the initial value: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the final value: ");
int max = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

/* int[] userArray = GetRandArray(min, max, userNumber);
bool find = FindNumber(userArray, desNumber);
PrintArray(userArray, find); */ //решение через bool

int[] userArray = GetRandArray(min, max, userNumber);
PrintArray(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();

System.Console.WriteLine("\nEnter the desired number: ");
int desNumber = Convert.ToInt32(Console.ReadLine());

FindNumber(userArray, desNumber);