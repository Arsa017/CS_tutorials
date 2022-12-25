namespace ClassesAsssiation
{
    public class Vehicle
    {
        private readonly string regNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string regNumber)
        {
            this.regNumber = regNumber;
            Console.WriteLine("Vehicle is being initialized. {0}", regNumber);
        }
    } 
}