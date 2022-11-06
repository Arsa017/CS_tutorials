using HelloWorld.Math;

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

            // adding Calculator class

            //var calculator = new Calculator();
            var result =  Calculator.Add(1, 2);
            Console.WriteLine(result);

            return 1;
        }
    }
}