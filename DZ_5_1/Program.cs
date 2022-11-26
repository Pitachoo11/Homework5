// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] NumberArray)
{
    for (int i = 0; i < NumberArray.Length; i++)
    {
        NumberArray[i] = new Random().Next(0, 1000);
    }
}

void FormattedPrintArray(int[] NumberArray)
{
    string[] result = Array.ConvertAll(NumberArray, x => x.ToString());
    Console.WriteLine($"[ {String.Join(", ", result)} ]");
}

void CountEvenNumbers(int[] NumberArray)
{
    int count = 0;
    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (NumberArray[i] %2 == 0)
        {
           count++;
        }
    }
    Console.WriteLine($"Количество четных элементов в массиве: {count}");
}

int[] array = new int [4];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);
Console.WriteLine();

CountEvenNumbers(array);
Console.WriteLine();
