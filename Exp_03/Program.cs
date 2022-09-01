/* Напишите программу, которая принимает на вход координаты точки (Х и Y), 
причём X <> 0 И Y<>0 и выдает номер четверти плоскости, в которой находится эта точка*/

int X1, X2 = 0;
int Y1, Y2 = 0;
int Z1, Z2 = 0;
double dist = 0;
Console.WriteLine($"Введите координаты точки A");
Console.Write($"Введите координату Х1: ");
int.TryParse(Console.ReadLine(), out X1);
Console.Write($"Введите координату Y1: ");
int.TryParse(Console.ReadLine(), out Y1);
Console.Write($"Введите координату Z1: ");
int.TryParse(Console.ReadLine(), out Z1);
Console.WriteLine($"Введите координаты точки B");
Console.Write($"Введите координату Х2: ");
int.TryParse(Console.ReadLine(), out X2);
Console.Write($"Введите координату Y2: ");
int.TryParse(Console.ReadLine(), out Y2);
Console.Write($"Введите координату Z2: ");
int.TryParse(Console.ReadLine(), out Z2);
Console.WriteLine($"Координаты первой точки: A ({X1}, {Y1}, {Z1})");
Console.WriteLine($"Координаты первой точки: B ({X2}, {Y2}, {Z2})");
Console.WriteLine($" Расстояние между точками в пространстве: {dist = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2))}");
