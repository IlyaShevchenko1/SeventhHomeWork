// Seventh home work

// Task 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value of array: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max value of array: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// (Метод void)

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementCheck(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1) && row >= 0 && column >= 0)
    Console.Write($"Value of the element of array with indexes ({row}, {column}) is: {array[row, column]}");
    else Console.WriteLine($"В массиве нет элемента с индексами ({row}, {column})");
  
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

Console.Write("Input a row number of necessary element: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number of necessary element: ");
int column = Convert.ToInt32(Console.ReadLine());

ElementCheck(myArray, row, column);

*/

// Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в
// каждом столбце.
// (Результат - одномерный массив)

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[] SumOfColumn(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    double sum = 0;
    double average = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];                      
        }
        
        average = sum / array.GetLength(0);
        newArray[j] = Math.Round(average, 1);
        sum = 0;
    }
    
    return newArray;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

double[] newArray = SumOfColumn(myArray);
WriteArray(newArray);

*/

// Additional task. Написать программу, преобразующую число из десятеричной системы счисления 
// в двоичную.

/*

string Convert10to2(int num)
{
    string temp = "";
    while (num != 0)
    {
        temp = temp + num % 2 + " ";
        num = num / 2;
    }
    
    string result = "";
    for (int i = 0; i < temp.Length; i++)
    {
        result = result + temp[temp.Length - 1 - i];
    }

    return result;
}

Console.Write("Input a DEC number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) Console.Write("Your number in BIN is: 0");
else
{
    string solution = Convert10to2(number);
    Console.Write("Your number in BIN is: ");
    Console.WriteLine(solution);
}

*/