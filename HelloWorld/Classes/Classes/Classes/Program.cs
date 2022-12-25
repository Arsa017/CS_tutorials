namespace Classes
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            //var person = new Person(new DateTime(1998,3,11));
            //Console.WriteLine(person.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "Aleksandar";
            Console.WriteLine(cookie["name"]);

        }
    
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 10, 12, 14, 16 }));
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("X: {0}  Y: {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("X: {0}  Y: {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error ocured!");
            }
        }
    
    }
}