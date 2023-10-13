// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
System.Console.WriteLine("Введите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
//int sqrX = (userBx - userAx) * (userBx - userAx);
//int sqrY = (userBy - userAy) * (userBy - userAy);
double sqrX = Math.Pow(userBx - userAx, 2);
double sqrY = Math.Pow(userBy - userAy, 2);
double root = Math.Sqrt(sqrX + sqrY);
System.Console.WriteLine(Math.Round(root, 3));
