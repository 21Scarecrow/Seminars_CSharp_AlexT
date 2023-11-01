/* 31. Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных 
и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20. */

Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if(i < arr.Length - 1)
        System.Console.Write(", ");

        if (arr[i] < 0)
            sumNeg += arr[i];
        else
            sumPos += arr[i];
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine($"\n\nСумма отрицательных чисел равна {sumNeg}");
    System.Console.WriteLine($"Сумма положительных чисел равна {sumPos}");

}
System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();