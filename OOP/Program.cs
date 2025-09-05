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
            string createPath = @"C:\TestDir";
            string movePath = @"C:\MovedDir";

            try
            {
                if (!Directory.Exists(createPath))
                {
                    Directory.CreateDirectory(createPath);
                    Console.WriteLine($"Каталог создан: {createPath}");
                } else
                {
                    Console.WriteLine($"Каталог уже существует");
                }

                if (Directory.Exists(createPath))
                {
                    if (!Directory.Exists (movePath))
                    {
                        Directory.Move(createPath, movePath);
                        Console.WriteLine($"Каталог перемещен из {createPath} в {movePath}");
                    }
                    else
                    {
                        Console.WriteLine($"Каталог назначения уже существует: {movePath}");
                    }
                } else
                {
                    Console.WriteLine($"Каталог для перемещения не существует: {createPath}");
                }

                if (Directory.Exists(movePath))
                {
                    Directory.Delete(movePath, true);
                    Console.WriteLine($"Каталог удален: {movePath}");
                } else
                {
                    Console.WriteLine($"Каталог для удаления не существует");
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }

           

            Console.ReadKey();
        }      
    }
}
