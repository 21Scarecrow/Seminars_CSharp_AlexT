/* 35. Задайте одномерный массив из 123 случайных чисел.
 Найдите количество элементов массива, значения которых лежат
 в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении 
сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

Console.Clear();
int[] GetRandArray()
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
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
void CountNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            count++;
    }
    System.Console.WriteLine($"Количество элементов в [10, 99] равно {count}");
}


int[] userArray = GetRandArray();
PrintArray(userArray);
System.Console.WriteLine("\n");
CountNumb(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();