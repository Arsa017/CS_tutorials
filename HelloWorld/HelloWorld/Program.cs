using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really really long text";

            var summary = StringUtility.SummerizeText(sentence, 15);
            Console.WriteLine(summary);
        }

    }
}