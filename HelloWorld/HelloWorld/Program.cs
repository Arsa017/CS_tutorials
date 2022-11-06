using System;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {

            var aleksandar = new Person();
            aleksandar.firstName = "Aleksandar";
            aleksandar.lastName = "Arsic";
            aleksandar.Introduce();

            return 1;
        }
    }
}