// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void SummNumbersOddIndex(int[] NumberArray)
{
    int summ = 0;
    for (int i = 1; i < NumberArray.Length; i=i+2)
    {
        summ = NumberArray[i] + summ;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summ}");
}

int[] array = new int [5];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);
Console.WriteLine();

SummNumbersOddIndex(array);
Console.WriteLine();
