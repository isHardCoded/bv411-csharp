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
            string[] lines = text.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}. {lines[i].ToUpper()}";
            }

            return string.Join("\n", lines);
        }
    }
    
    public class DirectoryManager
    {
        private string directoryPath;

        public DirectoryManager(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    throw new DirectoryNotFoundException("Директория не найдена: " + directoryPath);
                }
                this.directoryPath = directoryPath;
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                throw;
            }
        }

        public string[] ListFiles()
        {
            try
            {
                string[] files = Directory.GetFiles(directoryPath, "*.txt");
                if (files.Length == 0)
                {
                    throw new FileNotFoundException("В директории нет файлов с раширением .txt");
                }

                return files;

                
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return new string[0];
            }
        }

        public string ReadFile(string fileName)
        {
            try
            {
                string fullPath = Path.Combine(directoryPath, fileName);
                if (!File.Exists(fullPath))
                {
                    throw new FileNotFoundException("Файл не найден: " + fullPath);
                }

                TextFile textFile = new TextFile(fullPath);
                return textFile.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                return null;
            }
        }

        public void WriteFile(string fileName, string content)
        {
             try
            {
                string fullPath = Path.Combine(directoryPath, fileName);
                TextFile textFile = new TextFile(fullPath);
                textFile.Write(content);
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка при записи файла: " + ex.Message);
            }
        }

        public string FormatFile(string fileName) {
            try
            {
                string fullPath = Path.Combine(directoryPath, fileName);

                if (!File.Exists(fullPath))
                {
                    throw new FileNotFoundException("Файл не найден: " + fullPath);
                }

                TextFile textFile = new TextFile(fullPath);
                string content = textFile.Read();

                if (content == null) return null;

                return textFile.Format(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при форматировании файла: " + ex.Message);
                return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {        

            Console.ReadKey();
        }      
    }
}
