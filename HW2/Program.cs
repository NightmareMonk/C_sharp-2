// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


using System;
class Program
{
    static void Main()
    {
        int num(string mes)
        {
            Console.Write(mes);
            string i = Console.ReadLine();
            int result = int.Parse(i);
            return result;
        }
        int Third(int number)
        {
            while (number > 999)
            {
                number /= 10;
            }
            return number % 10;
        }
        bool eror(int number)
        {
            if (number < 100)
            {
                Console.WriteLine("нет ЕЁ!");
                return false;
            }
            return true;
        }
        int number = num("Введите число: ");
        if (eror(number))
        Console.WriteLine(Third(number));
    }
}