/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
            */

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

double[] ArrayGenerator(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-50, 51) + Math.Round( new Random().NextDouble(), 3);
        // получается new создаёт объект (экземпляр типа), без него компьютер не воспринимает результаты команд
    }
    return array;
}

double MinMaxDif(double[] array)
{
    double smallest = array[0],
           largest = array[0];
    foreach (double num in array)
    { 
        if (num > largest) largest = num;
        if (num < smallest) smallest = num; 
    }
    return largest - smallest;
}

void OutputMassive(double[] array)
{ //альтернатива циклу фор(работает не с индексами а с самими элементами)
    foreach (double item in array)
    { 
        Console.Write($"{item}\t "); // \t - табуляция
    }
    Console.WriteLine();
}

int size = InputInt("Введите размер массива");
double[] array = ArrayGenerator(size);
Console.Write("Сгенерированный массив: ");
OutputMassive(array);
Console.WriteLine($"Разница между max и min элементами массива = {MinMaxDif(array)}"); 
// иногда возникают баги на подобии число.00000001 (проблемы самого типа double, как понимаю?)