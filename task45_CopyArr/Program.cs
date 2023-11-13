/* 45. Напишите программу, которая будет создавать копию заданного 
одномерного массива с помощью поэлементного копирования.*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

int[] ArrayCopy(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i];
    }
    return newArray;
}
Console.Clear();
int userNumber = Prompt("Enter the size of the array: ");
int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);
int[] copyArray = ArrayCopy(userArray);
PrintArray(copyArray);
