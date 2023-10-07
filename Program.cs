// Задача 1 
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"Введённое Вами число: {number} -> вторая цифра этого числа {numberS[1]}" : "Вы ввели не трехзначное число");

//Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine( "Введите трёхзначное число:");
int M = Convert.ToInt32(Console.ReadLine());

    if ( M > 99 && M < 1000)
{
    int D = M % 10;
    Console.WriteLine ($"Третья цифра введённого Вами числа: {(D)}");
   
}
    else 
{
    Console.WriteLine("Это не трехзначное трёхзначное число, третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7:");
Console.WriteLine(Weekend(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string Weekend(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
            Console.Write("Под цифрой " + a + " - Выходной");
        else
            Console.Write("Под цифрой " + a + " - Рабочий");
    }
    else
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    return " день.";
}
