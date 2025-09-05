using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Line 1", "Line 2", "Line 3" };
            using (StreamWriter writer = new StreamWriter("file.txt", append: true))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.ReadKey();
        }      
    }
}
