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
            string path = @"C:\MyDir";

            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
                else
                {
                    Console.WriteLine("Каталог не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }      
    }
}
