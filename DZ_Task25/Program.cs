// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
long NumberInAPower(int num, int pow)
{
    result = num;
    for (int i = 1; i < pow; i++) result = result*num;
    return result;
}

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень, в которую нужно возвести число: ");
int power = Convert.ToInt32(Console.ReadLine());
if (power <= 0) Console.WriteLine("Вы ввели не натуральную степень, повторите ввод");
else
{
    long result = NumberInAPower(pow:power, num:number);
    Console.WriteLine($"{number}, {power} -> {result}");
}