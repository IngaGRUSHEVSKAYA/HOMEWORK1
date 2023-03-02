/*
int[,] CreateRandom2Array()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}

void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
    Console.WriteLine(); 
}
/*
Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
*/
/*
int[,] newArray = CreateRandom2Array();
Show2Array(newArray);
*/
// Задача 47. Задайте двумерный массив размером m*n, заполненный случайными
// вещественными числами.
/*
Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) /10;
        }    
           
    }
    
}

void PrintArray(double[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i,j] + " ");
        }
         Console.Write("] ");
          Console.WriteLine(" ");
   } 
}

*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например задан массив:

 //1 4 7 2
 //5 9 2 3
 //8 4 2 4

// 17 -> такого числа нет в массиве
/*
int[,] numbers = new int[3, 4];
FillArray2D(numbers);
PrintArray2D(numbers);
int rows = ReadInt("Input the row index: ");
int columns = ReadInt("Input the columns index: ");


if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
else Console.WriteLine($"{rows}{columns} -> такого числа нет в массиве");

void FillArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }    
           
    }
    
}

void PrintArray2D(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
/*
Random random = new Random();

int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];

for(int i = 0; i < array.GetLength(0); i++)
{for(int j = 0; j < array.GetLength(1); j++)
    
    {
        array[i,j] = random.Next(1, 10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
} 
Console.WriteLine("----------------");
Console.WriteLine(array.GetLength(0));

for(int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
     Console.Write($"{sum / array.GetLength(0)}");
}
Console.ReadLine();
*/
