using System;

class Program
{
    static void Main(string[] numb)
    {
        Console.WriteLine("Введите целое трёхзначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        int number1 = Math.Abs(number);
        if (number1 > 99 && number1 < 1000)
        {
            number1 = number1 / 10;
            number1 = number1 % 10;
            Console.WriteLine("Вторая цифра введённого Вами числа это " + number1);
        }
        else
        {
            Console.WriteLine("Нужно ввести корректное число");
        }
    }
}