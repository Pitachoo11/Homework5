// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] NumberArray)
{
    for (int i = 0; i < NumberArray.Length; i++)
    {
        NumberArray[i] = new Random().Next(1, 3);
    }
}

void FormattedPrintArray(int[] NumberArray)
{
    string[] result = Array.ConvertAll(NumberArray, x => x.ToString());
    Console.WriteLine($"[ {String.Join(", ", result)} ]");
}

void MultiplyPairsInArray(int[] NumberArray)
{
    int[] MultiplyArray = new int [NumberArray.Length % 2 == 0 ? NumberArray.Length/2 : NumberArray.Length/2+1];
    for (int i = 0; i < MultiplyArray.Length; i++)
    {
        if (i == NumberArray.Length -1 -i) 
        {
            MultiplyArray[i] = NumberArray[i];
        }
        else
        {
            MultiplyArray[i] = NumberArray[i] * NumberArray[(NumberArray.Length -1)-i];   
        }
    }
    Console.WriteLine();
    Console.WriteLine("Результат произведения пар чисел в одномерном массиве");
    FormattedPrintArray(MultiplyArray);
}

int[] NumArray = new int [5];
//int[] MultiplyArray = new int [NumArray.Length];

FillArray(NumArray);

Console.WriteLine();
FormattedPrintArray(NumArray);
Console.WriteLine();

MultiplyPairsInArray(NumArray);
Console.WriteLine();
