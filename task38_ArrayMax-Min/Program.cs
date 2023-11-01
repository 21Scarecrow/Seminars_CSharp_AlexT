/* 38 Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
double[] GetRandArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 10;
        //array[i] = Math.Round(new Random().NextDouble() * (maxValue + 0.01 - minValue) + minValue, 2);
    }
    return array;
}
void PrintArray(double[] arr)
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
void CalcDifferenceBetweenMaxMin(double[] array)
{

    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    double result = max - min;
    System.Console.WriteLine($"\nРазница между Max и Min элементами массива равна {result}");

}


System.Console.WriteLine("Enter the size of the array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the max value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] userArray = GetRandArray(userNumber, minValue, maxValue);
PrintArray(userArray);

System.Console.WriteLine("\n\nPress any key...");
Console.ReadKey();

CalcDifferenceBetweenMaxMin(userArray);