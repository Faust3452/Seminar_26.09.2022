// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int HowManyFigures(int num)
{
    int count = 1;
    while ((num / 10) != 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = HowManyFigures(number);
Console.WriteLine($"{number} -> {res}");