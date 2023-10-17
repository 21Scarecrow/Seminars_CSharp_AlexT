/*30. Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.*/
Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
}
System.Console.WriteLine("Enter the size of array: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userNumber);
PrintArray(userArray);