
// Задача 23. Напишите программу, которая на входе принимает число (N)
// и выдает таблицу кубов чисел от 1 до N.
/*
void PrintCube(int N)
{
    int i = 1;
    while(i <= N)
    {
        Console.Write(i * i * i + " ");
        i++;
    }
}
Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintCube(N);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
/*

double LineLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double L1 = x2 - x1;
    double L2 = y2 - y1;
    double L3 = z2 - z1;
    double result = Math.Sqrt((Math.Pow(L1, 2)) + (Math.Pow(L2, 2))+ (Math.Pow(L3, 2)));
    return result;
}
Console.Write("Input the coordinate X a first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y a first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Z a first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate X a second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y a second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Z a second point: ");
double z2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("LineLength: " + Math.Round(LineLength(x1, y1, x2, y2), 2));
Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2))));
*/





// Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
/*
int isPalindrome(int number)
{
    int rev = 0;
    int num = number;

    while (number != 0)
    {
       int r = number % 10;
       rev = rev * 10 + r;
       number = number / 10;
    }

    if (num == rev)
    {
        Console.Write("This is a Palindrome number!");
    }
    else
    {
        Console.Write("This value is not a Palindrome number!");
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("num == rev ?, Palindrome, not a Palindrome");
*/





