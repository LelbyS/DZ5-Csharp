// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Main ();

void Main ()
{
    int length = IntRead("введите размер массива");
    int min = IntRead("введите минимальный порог чисел массива");
    int max = IntRead("введите максимальный порог чисел массива");
    int[] array = GetArray(length,min,max);
    PrintArray(array);
    System.Console.WriteLine($"максимальное число в массиве {Max(array)},минимальное число в этом же массиве {Min(array)}");
    System.Console.WriteLine($"разница между ними равна  {Max(array)-Min(array)}");
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i]+"; ");
    }
    System.Console.WriteLine($"{array[array.Length-1]}]");
}

int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"{argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("вы ввели не корректные данные");
    }
    return number;
}