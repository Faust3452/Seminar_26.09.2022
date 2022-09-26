// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

long Multiple(long num)
{
    long res = 1;
    while (num > 0)
    {
        res = res * num;
        num = num - 1;
    }
    return res;
}

Console.WriteLine("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
if (number <= 0) Console.WriteLine("Вы ввели отрицательное или нулевое значение! Повторите!");
else
{
    long result = Multiple(number);
    Console.WriteLine($"{number} -> {result}");
}