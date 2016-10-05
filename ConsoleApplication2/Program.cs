using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"You Wrote: {input}");

            Console.ReadLine();
        }
    }
}
