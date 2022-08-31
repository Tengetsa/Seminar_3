// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double x1, x2, y1, y2, z1, z2;

Console.WriteLine("Введите координаты x1: ");
x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y1: ");
y1 =  double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты z1: ");
z1 =  double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты x2: ");
x2 =  double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y2: ");
y2 =  double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты z2: ");
z2 =  double.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(result);
