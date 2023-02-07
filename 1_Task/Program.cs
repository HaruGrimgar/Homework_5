/* 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenCounter(int[] array)
{
    int counter = 0;
    foreach (int num in array) // не нужно использовать array.Length, в отличии for( int i = 0; i < array.Length; i++)
    {
        if (num % 2 == 0) counter++;
    }
    return counter;
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
Console.WriteLine($"Количество чётный элементов в массиве = {EvenCounter(array)}");