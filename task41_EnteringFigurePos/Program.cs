/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] EnteringArray(double[] args, int size)
{
    int N = size; // размер массива
    double[] array = new double[N]; // массив

    // ввод массива
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < N; i++)
    {
        Console.Write("{0}>", i + 1); // вывод с счетчиком
        array[i] = System.Convert.ToDouble(Console.ReadLine());
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
void CountPosElements(double[] arr)
{
    System.Console.WriteLine();
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    System.Console.WriteLine($"\nКоличество элементов массива больше 0 равно {count}");
}

int size = Prompt("Enter the size of the array: ");
double[] userArray = new double[size];
double[] fullArray = EnteringArray(userArray, size);
PrintArray(fullArray);
CountPosElements(fullArray);

/*
void EnteringArray(string[] args, int size)
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
        Console.Write(a[i]);
        if (i < a.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");

    Console.Write("\n\nPress any key...");
    Console.ReadKey();

    //подсчет количества элементов массива > 0
    System.Console.WriteLine();
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i] > 0) count++;
    }
    System.Console.WriteLine($"Количество элементов массива больше 0 равно {count}");
}

Console.Clear();
System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

string[] userArray = new string[size];

EnteringArray(userArray, size);*/