using System;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static int Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);

            Console.WriteLine(method.ToString());

            var MethodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), MethodName);
            Console.WriteLine(shippingMethod);

            return 1;
        }
    }
}