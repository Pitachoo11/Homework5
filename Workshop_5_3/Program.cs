// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void SearchNumberInArray(int[] NumberArray, int Number)
{
    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (NumberArray[i] == Number)
        {
           Console.WriteLine("Да");
           return; 
        }
    }
    Console.WriteLine("Нет");
}

Console.WriteLine("Введите число для поиска в массиве:");
int Number = Convert.ToInt32(Console.ReadLine());

int[] array = new int [10];

FillArray(array);

Console.WriteLine();
FormattedPrintArray(array);
Console.WriteLine();

SearchNumberInArray(array,Number);
Console.WriteLine();
