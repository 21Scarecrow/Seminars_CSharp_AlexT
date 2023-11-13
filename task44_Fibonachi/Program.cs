/* 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{

    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
}

int[] Fibon(int number)
{
    int size = number;
    int[] array = new int[size];

    if (number == 1) array[0] = 0;
    if (number == 2) array[1] = 1;
    if (number > 2)
    {
        array[0] = 0;
        array[1] = 1;
    }

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;

}

int decNumber = Prompt("Enter the number: ");

PrintArray(Fibon(decNumber));