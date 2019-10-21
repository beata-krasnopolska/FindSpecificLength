using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSpecificLengthLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program finds the strings with a specific minimum length");
            List<string> Cities = new List<string> { "Rzeszów", "Kraków", "Lublin", "Łódź", "Warszawa", "Gdańsk" };

            Console.WriteLine("Enter minimum string length");
            int wordLength = int.Parse(Console.ReadLine());

            var myCities = from city in Cities
                           where city.Length >= wordLength
                           orderby city
                           select city;
            var myCitiesLambda = Cities.Where(x => x.Length > wordLength).OrderBy(x => x);

            Console.WriteLine("Words with a minimum length of {0} characters are:", wordLength);
            Console.WriteLine("First check by LINQ query:");
            foreach (var city in myCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
            Console.WriteLine("Second check by LINQ method:");
            foreach (var i in myCitiesLambda)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
