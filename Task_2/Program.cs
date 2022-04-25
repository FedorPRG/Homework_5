void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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
int Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] mass = new int[length];
FillArray(mass);
Print(mass);
int rez = Summ(mass);
Console.WriteLine($"В заданном массиве сумма элементов, стоящих на нечётных позициях = {rez}");