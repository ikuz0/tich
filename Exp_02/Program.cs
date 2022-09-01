Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int polindrom(int number)
{

    int pol = 0;
    while (number > 0)
    {
        pol = pol * 10 + number % 10;
        number = number / 10;
        // Console.WriteLine(pol);
    }
    return pol;
}

int polEnd = polindrom(number);

if (number == polEnd)
{
    Console.Write($"{number} -> Да");
}
else
{
    Console.Write($"{number} -> Нет");
}