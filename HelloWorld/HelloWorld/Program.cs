using System;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                //console.writeline(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Prekoracenje pri konverziji tipa!");
            }


            // operators demo

            var a = 10;
            var c = 3;
            var d = 5;
            //Console.WriteLine(!(a != d));
            Console.WriteLine(a > c || a < d);
            return 1;
        }
    }
}