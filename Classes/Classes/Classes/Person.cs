using System.Reflection.Metadata.Ecma335;

namespace Classes
{

    internal partial class Program
    {
        public class Person
        {
            //public string Name { get; set; }
            //public string Username { get; set; }
            public DateTime Birthdate { get; private set; }         // auto-implement propery


            public Person(DateTime birthdate)
            {
                Birthdate = birthdate;
            }

   
            
            public int Age              
            {
                get
                {
                    var timespan = DateTime.Today - Birthdate;
                    var years = timespan.Days / 365;

                    return years;
                }
            }

        }
    
    }
}