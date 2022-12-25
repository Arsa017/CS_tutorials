using System.Collections.Generic;

namespace AdvancedLvl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // args => expression

            //number => number * number

            // () => ...                lambda expression with no parameters
            // x => ...                 with one parameter
            // (x, y, z) => ....        with multiple parameters

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);  




        }

    }
    

}