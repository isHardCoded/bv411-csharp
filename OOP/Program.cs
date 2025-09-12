using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace OOP {
    class Rectangle
    {
        public int width { get; set; }
        public int length { get; set; }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public override string ToString()
        {
            return $"Rectangle: Length={length}, Width={width}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect = new Rectangle(5, 10);
            //string json = JsonSerializer.Serialize(rect);
            //File.WriteAllText("file.json", json);

            string json = File.ReadAllText("file.json");

            Rectangle rect = JsonSerializer.Deserialize<Rectangle>(json);
            Console.WriteLine(rect);
        }      
    }
}
