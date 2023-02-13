/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}
/*
Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/
/*
int GetSumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}





//Задача 41. Пользователь вводит с клавиатуры М чисел.Посчитайте,сколько
// чисел больше 0 ввел пользователь.
/*
void StringToNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
       
    }
    Console.WriteLine();
    Console.WriteLine($"{count} numbers > 0");
}
Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int[] myArray = CreateRandomArray(length, -100, 100);
ShowArray(myArray);
StringToNum(myArray);
*/
//Задача 43. Напишите программу, которая найдет точку пересечения 
//двух прямых, заданных уравнениями y=k1*x + b1, y = k2*x + b2, 
//значения b1,k1,b2 и k2 задаются пользователем.
/*
Console.WriteLine("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double X = (b2 -b1) / (k1 - k2);
double Y = k2 * X + b2;

Console.WriteLine($"two straight lines will intersect at a point with coordinates X: {X}, Y: {Y}");
*/