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
        }
    }
}
