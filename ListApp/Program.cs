using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var cities = new List<string>()
            {
                "Kayseri",
                "Malatya",
                "Trabzon",
                "Çorum",
                "Ankara"
            };

            Console.WriteLine("\"Cities list using foreach.\"");
            foreach (string c in cities) {
                Console.WriteLine("{0,15}",c);
            }
            Console.WriteLine(new String('-', 50));

            // Lambda Expression
            Console.WriteLine("\"Cities list useing lambda expression.\"");
            cities.ForEach(c => Console.WriteLine("{0,15}", c));
            Console.WriteLine(new String('-',50));

            Console.WriteLine("\"New list named iller that = cities\"");
            var iller = cities;
            iller.ForEach(i => Console.WriteLine("{0,15}", i));
            Console.WriteLine();

            Console.WriteLine("\"Kırşehir added just in cities list.\"");
            cities.Add("Kırşehir");
            cities.ForEach(c => Console.WriteLine("{0,15}", c));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine("{0,15}", i));
            Console.WriteLine();

            Console.WriteLine("\"Ankara deleted just in iller list.\"");
            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine("{0,15}", i));
            Console.WriteLine();
            cities.ForEach(c => Console.WriteLine("{0,15}", c));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
