// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;
class Program
{
    static void Main()
    {
        int num(string mes)
        {
            Console.WriteLine(mes);
            string i = Console.ReadLine();
            int result = int.Parse(i);
            return result;
        }
        int number = num("Введите трехзначное число > ");
        if (number < 100 || number >= 1000)
        {
            Console.WriteLine("Не трехзначное, повторите попытку");
            return;
        }
        Console.WriteLine($"Это трехзначное число {number} ");
        int Second = number / 10 % 10;
        Console.WriteLine($"Второая {Second} ");

        

    }
}