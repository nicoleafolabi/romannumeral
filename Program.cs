using System;

namespace romannumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3999; i > 0; i -= 1)
            {
                Console.WriteLine($"{i} = {Convertor.toRoman(i)} = {Convertor.toInteger(Convertor.toRoman(i))}");
            }

            Console.WriteLine($"Error check for a number > 3999: {Convertor.toRoman(4000)}");
            Console.WriteLine($"Error check for a number <= 0: {Convertor.toRoman(0)}");
        }
    }
}
