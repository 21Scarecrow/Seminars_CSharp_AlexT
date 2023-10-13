// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
System.Console.WriteLine("Введите координаты точки A (x, y, z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

double sqrX = Math.Pow(userBx - userAx, 2);
double sqrY = Math.Pow(userBy - userAy, 2);
double sqrZ = Math.Pow(userBz - userAz, 2);

double root = Math.Sqrt(sqrX + sqrY + sqrZ);
System.Console.WriteLine(Math.Round(root, 2));