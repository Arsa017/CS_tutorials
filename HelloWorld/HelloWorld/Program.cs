using System;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            var firstName = "Pera";
            var lastName = "Peric";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "Pera", "Zika", "Mika" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            //var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder2\\folder3";
            var text = @"Hi John
                        Look into the following path
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);

            return 1;
        }
    }
}