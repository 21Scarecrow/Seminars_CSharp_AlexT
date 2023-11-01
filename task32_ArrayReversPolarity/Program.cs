/* 32. Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные,
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */


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
    System.Console.WriteLine("] ->");
}
void ReversPolarity(int[] array)
{
    System.Console.WriteLine();
    System.Console.Write("-> [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] * -1);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}
System.Console.WriteLine("Enter the initial value: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the final value: ");
int max = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(min, max, userNumber);
PrintArray(userArray);
ReversPolarity(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();