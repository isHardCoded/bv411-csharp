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
            string path = @"C:\NewDirectory";

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Каталог уже существует");
                } else
                {
                    DirectoryInfo dir = Directory.CreateDirectory(path);
                    Console.WriteLine($"Каталог создан успешно по пути: {dir.FullName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }      
    }
}
