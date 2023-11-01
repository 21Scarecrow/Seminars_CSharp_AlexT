/* 34 Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 */

Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
void CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    System.Console.WriteLine($"Количество четных чисел равно {count}");
}


System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);
CountEven(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();