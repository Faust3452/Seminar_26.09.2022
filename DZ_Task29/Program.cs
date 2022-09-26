// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayGen(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов массива: ");
int numElements = Convert.ToInt32(Console.ReadLine());
if (numElements <= 0) Console.WriteLine("Введено отрицательное или нулевое значение размера массива\nПовторите ввод");
else
{
    Console.WriteLine("Введите наименьшее число их диапазона генерации элементов массива: ");
    int minElementGen = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите наибольше число их диапазона генерации элементов массива: ");
    int maxElementGen = Convert.ToInt32(Console.ReadLine());
    if (minElementGen > maxElementGen) Console.WriteLine("Наименьшеe число для генерации больше наибольшего\nПовторите ввод");
    else 
    {
        int[] array = ArrayGen(numElements, minElementGen, maxElementGen);
        PrintArray(array);
    }
}
