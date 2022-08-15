using System;

class Program
{
    static void Main(string[] day)
    {
        Console.WriteLine("Введи цифру от 1 до 7, где 1 - это понедельник, 2 - это вторник и так далее...");
        int numb = Convert.ToInt32(Console.ReadLine());

        string[] week = { "1 - Понедельник", "2 - Вторник", "3 - Среда", "4 - Четверг", "5 - Пятница", "6 - Суббота", "7 - Воскресенье" };

        int index = numb - 1;

        if (numb <= 5)
        {
            Console.WriteLine(week[index] + " - это рабочий день!");
        }
        else
        {
            Console.WriteLine(week[index] + " - это выходной!");
        }
    }   
}