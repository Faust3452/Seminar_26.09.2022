// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] MassFill(int range)
{
    int[] arr = new int[range];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(0,2);
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

int[] array = MassFill(8);
PrintArray(array);