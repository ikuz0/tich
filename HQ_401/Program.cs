/* Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Sq(int arg1, int arg2)
{
    int sq_r = 1;
    int i = 1;
    while (i != arg2 + 1)
    {
        sq_r = sq_r * arg1;
        i++;
    }
    int result = sq_r;
    return result;
}
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
int max = Sq(a, b);
Console.WriteLine(max);
