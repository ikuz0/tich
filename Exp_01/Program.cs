Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"{number} ->");
for (int i = 1; i < number + 1; i++)
{
    Console.Write($" {Math.Pow(i, 3)}");
}