// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumOfFiguresInNumber(int num)
{
    if (num < 0) num = - num;
    int result = 0;
    while (num / 10 != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    result = result + num;
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SumOfFiguresInNumber(number);
Console.WriteLine($"{number} -> {res}");