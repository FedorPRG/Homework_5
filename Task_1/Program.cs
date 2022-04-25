void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
int Count(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            count = count + 1;
        }
    } return count;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] mass = new int[length];
FillArray(mass);
Print(mass);
int count= Count(mass);
Console.WriteLine($"В заданном массиве присутствуют четные числа - {count} раз");
