/* 42. Напишите программу, которая будет преобразовывать десятичное
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void DecToBin(int number)
{
    int temp = 0;
    string binNumber = "";// пустая строковая переменнная

    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        binNumber = temp + binNumber; //на каждом кругу цикла записываем
                                      //новое значение temp слева от,
                                      //уже имеющегося в нашей строковой
                                      //переменной
    }
System.Console.WriteLine(binNumber);

}

int decNumber = Prompt("Enter the number: ");
DecToBin(decNumber);

/* Способ через int
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
int result= 0;
int ten = 1;
while(number>0)
{
result=number%2*ten+result;
number=number/2;
ten=ten*10;
}
return result;
}
int Number = ToBinary(number);
Console.Write(Number);
*/

/* Еще один способ
int decimalNumber = 42;
string binaryNumber = Convert.ToString(decimalNumber, 2);
Console.WriteLine(binaryNumber); */