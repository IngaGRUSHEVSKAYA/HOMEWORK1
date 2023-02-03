// Задача 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает ВТОРУЮ цифру этого числа.
/*
int CutNumber(int number);
{
    int sot = number / 10;
    int ed = number % 10;

    int result = ((number/10)%10);
    return result; 
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа.
/*
int MakeArray(int a, int b)
{
    int result = 0;
    if (b <3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i --)
        {
            c = c * 10;
        }
        result = (a / c ) % 10;
    }
    return result;
}
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
Console.Write("Третьей цифры нет");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/





// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
/*
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if  (a ==7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }    
    else 
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день. ";   
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

*/
