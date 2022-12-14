// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк:");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов:");
    int columns = int.Parse(Console.ReadLine());

    Console.Write("Введите положение строки: ");
    int rowsPositions = int.Parse(Console.ReadLine());

    Console.Write("Введите положение стобца: ");
    int columnsPositions = int.Parse(Console.ReadLine());

    int[,] array = NewArray(rows, columns);
    PrintArray(array);
    Console.WriteLine();
    if(rowsPositions> rows || columnsPositions> columns)
    {
        Console.WriteLine($"Позиции [{rowsPositions}, {columnsPositions}] нет");
    }
    else 
    {
        Console.WriteLine($"{array[rowsPositions,columnsPositions]}");
    }
}

int[,] NewArray(int m, int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Main();

