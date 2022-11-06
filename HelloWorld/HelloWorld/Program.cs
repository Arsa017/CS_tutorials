using System;

namespace HelloWorld
{

    class Program
    {
        static int Main(string[] args)
        {

            var person = new Person() { age = 25 };

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            MakeOld(person);
            Console.WriteLine(person.age);

            return 1;
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}