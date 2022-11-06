using System;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            var number = "1234";

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            } catch (Exception e)
            {
                Console.WriteLine("Prekoracenje pri konverziji tipa!");
            }
               

            return 1;
        }
    }
}