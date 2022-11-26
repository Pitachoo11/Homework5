// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] NumberArray)
{
    for (int i = 0; i < NumberArray.Length; i++)
    {
        NumberArray[i] = new Random().Next(-9, 10);
    }
}

void FormattedPrintArray(int[] NumberArray)
{
    string[] result = Array.ConvertAll(NumberArray, x => x.ToString());
    Console.WriteLine($"[ {String.Join(", ", result)} ]");
}

void FindMinMaxInArray(int[] NumberArray)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (NumberArray[i] > max)
        {
           max = NumberArray[i];
        }
        if (NumberArray[i] < min)
        {
           min = NumberArray[i];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max-min}");
}

int[] array = new int [5];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);
Console.WriteLine();

FindMinMaxInArray(array);
Console.WriteLine();