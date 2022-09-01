Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int SumNum(int number)
{

    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
        //Console.WriteLine(sum);
    }
    return sum;
}

Console.WriteLine(SumNum(number));
