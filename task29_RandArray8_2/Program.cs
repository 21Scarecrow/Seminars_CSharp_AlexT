/* 29. Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

void FillArray(string[] args, int size)
{
    int N = size; // размер массива
    double[] a = new double[N]; // массив

    // ввод массива
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < N; i++)
    {
        Console.Write("{0}>", i + 1); // вывод с счетчиком
        a[i] = System.Convert.ToDouble(Console.ReadLine());
    }

    // вывод массива
    Console.Write("\nМассив: "); // \n - перевод на новую строку
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < N; i++)
    {
        /*Console.Write("{0:n} ", a[i]); вывод десятичной части
        элементов массива*/
        Console.Write(a[i]);
        if (i < a.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");

    Console.Write("\n\nPress any key...");
    Console.ReadKey();
}
Console.Clear();
System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

string[] userArray = new string[size];

FillArray(userArray, size);