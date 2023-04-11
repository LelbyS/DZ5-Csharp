// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Main ();

void Main ()
{
    int lenght = IntRead("введите размер массива");
    int min = IntRead("введите минимальный порог значений массива");
    int max = IntRead("введите максимальный порог значений элементов массива");
    int[] array = GetArray(lenght, min, max);
    PrintArray(array);
    System.Console.WriteLine($"сумма нечетных элементов массива равна {Summ(array)}");

}

int[] GetArray(int lenght, int min, int max)

{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max+1);        
    }
    return array;
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

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"{argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("введенные данные не являются числом!!!");
    }
    return number;
}

int Summ(int[] numbers)
{
    int summ = 0;
    for (int i = 1; i < numbers.Length; i = i + 2)
    {
        summ = summ + numbers[i];    
    }
    return summ;
}