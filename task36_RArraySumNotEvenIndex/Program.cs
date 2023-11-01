/* 36 Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
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
void SumNotEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    // for( int i = 1; i < array.Length; i += 2)
    {
        if (i % 2 != 0) // тогда это условие не нужно
            sum = array[i] + sum;
    }
    System.Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
}


System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);
SumNotEvenIndex(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();