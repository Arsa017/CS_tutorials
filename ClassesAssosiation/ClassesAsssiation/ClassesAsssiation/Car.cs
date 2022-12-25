namespace ClassesAsssiation
{
    public class Car : Vehicle
    {
        public Car(string regNumber)
            :base(regNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", regNumber);
        }
    }
}