using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>() { 1, 2, 3 };
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.AddRange(new int[4] { 20, 21, 22, 1 });

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("count: " + numbers.Count);


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Clear();
            Console.WriteLine("count: " + numbers.Count);
        }
    }
}