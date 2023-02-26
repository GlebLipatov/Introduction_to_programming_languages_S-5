Console.WriteLine("Задача 34\n");

EvenNumbers(IntArrayCreator(new Random().Next(10, 100), 100, 1000));

Console.WriteLine("\nЗадача 36\n");

SumOddNumbers (IntArrayCreator(new Random().Next(100, 1000), 10, 100));

Console.WriteLine("\nЗадача 38\n");

DiffMinMaxDouble();

// ============================= \\

int[] IntArrayCreator(int length, int from, int till)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++) 
    {
        array[i] = new Random().Next(from, till);
    }
    return array;
}

void EvenNumbers(int[] numbers)
{
    int count = 0;
    int length = numbers.Length;

    for (int i = 0; i < length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine($"В массиве длиной из {length} чисел сохраненно {count} четных чисел");
}

void SumOddNumbers(int[] numbers)
{
    int length = numbers.Length;
    int result = 0;

    for (int i = 1; i < length; i+=2)
    {
        result += numbers[i];
    }
    Console.WriteLine($"Сумма чисел в нечетных индесах массива длиной {length} элемента ровна {result}");
}

void DiffMinMaxDouble()
{
    double[] array = new double[new Random().Next(100, 1000)];
    int length = array.Length;
    double min = double.MaxValue;
    double max = double.MinValue;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;

        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }

    Console.WriteLine($"Разница между {max} и {min} ровна {double.Round(max) - double.Round(min)}");
}