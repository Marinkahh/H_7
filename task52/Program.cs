// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
     Console.Clear();
    Console.Write("Введите количество строк:");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов:");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = NewArray(rows, columns);
    PrintArray(array);
    Console.WriteLine();
    MediumArray(array);
   
    
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

void MediumArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        Console.Write($"{(sum/(arr.GetLength(1)))}, ");
    }   

}


void PrintArray(int [,] inArray)
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

