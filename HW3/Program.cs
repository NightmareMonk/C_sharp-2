// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




using System;
class Program

{
    static void Main()
    {
        int num (string mes)
        {
        Console.Write(mes);
        string i = Console.ReadLine()!;
        int result = int.Parse(i);
        return result;
        }

        bool Week(int weekDay)
        {
        if (weekDay > 5)
        {
            return true;
        }
        return false;
        }
    

    bool weekNumber(int number)
    {
        if (number > 0 && number <= 7)
        {
            return true;
        }
        Console.WriteLine("Не месяца! Не года! День недели давай...");
        return false;
    }

        int weekDay = num("введите день недели ");
        if (weekNumber(weekDay))
        {
            if (Week(weekDay))
            {
                Console.WriteLine("ВЫходНОЙ!");
            }
            else
            {
                Console.WriteLine("Будни ..юдни!");
            }
        }
    }
}