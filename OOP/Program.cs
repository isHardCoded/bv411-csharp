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
            string sourceDir = @"C:\sourceDir";
            string destDir = @"C:\destDir";

            try
            {
                Directory.Move(sourceDir, destDir);
                Console.WriteLine($"Каталог успешно перемещен из {sourceDir} в {destDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }      
    }
}
