using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    public class TextFile
    {
        public string filePath { get; private set; }

        public TextFile(string filePath)
        {
            this.filePath = filePath;
        }

        public string Read()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Файл не найден", filePath);
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                return null;
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            Console.Write("Введите текст, который хотите записать в файл: ");
            string textToWrite = Console.ReadLine();

            TextFile file = new TextFile(path);

            string fileContext = file.Read();
            Console.WriteLine("Содержимое файла:");
            Console.Write(fileContext);

            Console.ReadKey();
        }      
    }
}
