// Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого 
// элемента или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Введите позицию на какой строке: ");
    int linePosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию в каком столбце: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число для проверки: ");
    int numberToCheck = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (arr[linePosition - 1, columnPosition - 1] == numberToCheck)
    {
        Console.WriteLine($"{numberToCheck} - такое число в массиве есть");
    }
    else
    {
        Console.WriteLine($"{numberToCheck} - такого числа в массиве нет");
    }
}

const int numberOfLines = 5;
const int numberOfColumns = 4;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);
CheckNumber(array);


