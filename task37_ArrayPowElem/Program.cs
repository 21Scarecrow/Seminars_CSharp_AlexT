/* 37. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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
int[] ProductArray(int[] array)
{
    int size = array.Length - array.Length / 2;
    int[] result = new int[size];
    System.Console.WriteLine(size);
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
        result[size - 1] = array[size - 1];

return result;
}

System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);
System.Console.WriteLine("\n");
int[] newArray = ProductArray(userArray);
System.Console.WriteLine();
PrintArray(newArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();