/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayGenerator(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

int total_of_numbers_on_odd_index(int[] array)
{
    int total = 0;
    for (int i = 1; i < array.Length; i += 2) // важен индекс, поэтому используем for
    {
        total += array[i];  // ошибку не выдаёт, так как условие i < array.Length - не позволяет выйти за размеры массива
    }
    return total;
}

void OutputMassive(int[] array)
{ //альтернатива циклу фор(работает не с индексами а с самими элементами)
    foreach (int item in array)
    { 
        Console.Write($"{item}\t "); // \t - табуляция
    }
    Console.WriteLine();
}

int size = InputInt("Введите размер массива");
int[] array = ArrayGenerator(size);
Console.Write("Сгенерированный массив: ");
OutputMassive(array);
Console.WriteLine($"Cумма элементов на нечётных индексах = {total_of_numbers_on_odd_index(array)}");
