// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] NumberArray)
{
    for (int i = 0; i < NumberArray.Length; i++)
    {
        NumberArray[i] = new Random().Next(0, 100);
    }
}

void FormattedPrintArray(int[] NumberArray)
{
    string[] result = Array.ConvertAll(NumberArray, x => x.ToString());
    Console.WriteLine($"[ {String.Join(", ", result)} ]");
}

void CountNumbersFrom10To99(int[] NumberArray)
{
    int count = 0;
    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (NumberArray[i] >= 10 && NumberArray[i] <= 99)
        {
           count++;
        }
    }
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
}

int[] array = new int [123];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);
Console.WriteLine();

CountNumbersFrom10To99(array);
Console.WriteLine();