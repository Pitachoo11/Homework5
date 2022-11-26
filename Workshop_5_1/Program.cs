// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

void SummOfPosNegNumbersArray(int[] NumberArray)
{
    int PosSumm = 0;
    int NegSumm = 0;

    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (NumberArray[i] > 0)
        {
            PosSumm = PosSumm + NumberArray[i];
        }
        if (NumberArray[i] < 0)
        {
            NegSumm = NegSumm + NumberArray[i];
        }
    }
    Console.WriteLine($"Сумма всех положительных чисел массива: {PosSumm}");
    Console.WriteLine($"Сумма всех отрицательных чисел массива: {NegSumm}");
}

int[] array = new int [12];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);

Console.WriteLine();
SummOfPosNegNumbersArray(array);
Console.WriteLine();