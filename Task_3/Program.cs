void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void Print(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write($"{array[length - 1]}.");
    Console.WriteLine();
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}
int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] mass = new int[length];
FillArray(mass);//Заполнение массива
Print(mass);//Вывод на экран массива
int a=Min(mass);//Поиск минимального числа в массиве
int b=Max(mass);//Посик максимального числа в массиве
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {b-a}");
