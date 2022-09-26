// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int Sum(int num)
{
    int result = default;
    for (int i = 1; i < num + 1; i++)
    {
        result = result +i;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Вы ввели отрицательное число, попробуйте заново");
else
{
    int res = Sum(number);
    Console.WriteLine($"{number} -> {res}");
}