// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координаты точки A по оси X: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A по оси Y: ");
int Ya = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A по оси Z: ");
int Za = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B по оси X: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B по оси Y: ");
int Yb = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B по оси Z: ");
int Zb = int.Parse(Console.ReadLine());

double result =  Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
Console.WriteLine($"Расстояние между точками A и В в 3D-пространстве равно {Math.Round(result, 2)}");