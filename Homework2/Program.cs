using System;

class Program
{
    static int Count_check(int numbr)
    {
        int count = 0;
        while (numbr > 9)
        {
            numbr = numbr / 10;
            count++;
        }
        return count;
    }
    static void Main(string[] numb)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int mod_numb = Math.Abs(number);
        int third_num = 0;

        if (mod_numb > 99)
        {
            int count = Count_check(mod_numb);

            int count_1 = count - 1;
            int count_2 = count - 2;
            int for_third_num_1 = Convert.ToInt32(Math.Pow(10, count_1));
            int for_third_num_2 = mod_numb / for_third_num_1;
            int for_third_num_3 = Convert.ToInt32(Math.Pow(10, count_2));

            third_num = (mod_numb - (for_third_num_2 * for_third_num_1)) / for_third_num_3;

            Console.WriteLine(third_num);

        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}
