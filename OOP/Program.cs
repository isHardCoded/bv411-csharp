using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace OOP {

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> names = new List<string>() { "John", "Tom", "Jim" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("Tim");
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("Tom");
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAt(0);
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Insert(2, "Bob");
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Clear()
            // Contains(item) 
            // Count
            
        }   
    }
}
