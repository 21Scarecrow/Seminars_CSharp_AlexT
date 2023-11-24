/* 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, 
 добавляя индексы каждого элемента. */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,,] Generate3dArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int currentNumber = 10; // начинаем с двузначного числа

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                array[i, j, k] = currentNumber++;
            }
        }
    }

    return array;
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
            }
        }
    }
}
int userX = Prompt("Enter the x: ");
int userY = Prompt("Enter the y: ");
int userZ = Prompt("Enter the z: ");

// Создаем трехмерный массив 
int[,,] threeDArray = Generate3dArray(userX, userY, userZ);

// Выводим массив с добавлением индексов
Print3dArray(threeDArray);

System.Console.WriteLine("Press any key...");
Console.ReadKey(); // Чтобы консоль не закрывалась сразу