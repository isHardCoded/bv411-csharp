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
    
        public void Write(string content)
        {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }          
        }
    
        public string Format(string text)
        {
            // привести весь текст к верхнему регистру
            // добавить нумерацию строк

            // Входные данные: 
            // hello
            // world

            // Выходные данные:
            // 1. HELLO
            // 2. WORLD

            string[] lines = text.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}. {lines[i].ToUpper()}";
            }

            return string.Join("\n", lines);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            TextFile file = new TextFile(path);

            //Console.Write("Введите текст, который хотите записать в файл: ");
            //string textToWrite = Console.ReadLine();

            //file.Write(textToWrite);
            //Console.WriteLine("Данные записаны");
            
            string fileContent = file.Read();
            Console.WriteLine("Содержимое файла: \n");
            Console.WriteLine(fileContent);

            string formatText = file.Format(fileContent);
            Console.WriteLine("Отформатированный текст:\n");
            Console.WriteLine(formatText);

            Console.ReadKey();
        }      
    }
}
