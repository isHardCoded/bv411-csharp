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
           Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("name", "Apple");
            string value = dict["name"];

            Console.WriteLine(value);

            // ContainsKey(key)
            // ContainsValue(value)
            // Clear()
            // Remove(key)
        }   
    }
}
