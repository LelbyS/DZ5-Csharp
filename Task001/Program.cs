// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Main ();

void Main ()
{
    int lenght = IntRead("введите размер массива");
    int min = IntRead("введите минимальный предел массива");
    int max= IntRead("введите максимальный предел массива");
    int[] array = GetArray(lenght, min, max);
    PrintArray(GetArray(lenght, min, max));
    int summ = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] % 2 > 0) ;
        else summ++;
    }
    System.Console.WriteLine(summ);

}

void PrintArray(int[] array)
{
    System.Console.Write($"[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i]+"; ");
    }
    System.Console.WriteLine($"{array[array.Length-1]}]");
}

int[] GetArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
    
}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"{argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("введенные данные не являются числом");
    }
    return number;
}