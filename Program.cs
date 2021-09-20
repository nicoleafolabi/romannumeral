using System;

namespace romannumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            // var convert = new Convertor();
            var romanText1 = Convertor.toRoman(3);
            Console.WriteLine($"{romanText1}");
        }
    }
}
