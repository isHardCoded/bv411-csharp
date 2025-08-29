using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    // abstract Document { id, author, abstract ShowData() }
    abstract class Document
    {
        private string id;
        private string author;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Document(string author)
        {
            Id = Guid.NewGuid().ToString();
            Author = author;
        }

        public abstract void ShowData();
    }

    // TextDocument : Document { content, override ShowData() }

    class TextDocument : Document
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public TextDocument(string author, string content) : base(author)
        {
            Content = content;
        }

        public override void ShowData()
        {
            Console.WriteLine($"Текстовый документ (ID: {Id})");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Содержание: {Content}");
        }
    }

    // SignedDocument : Document { signature, override ShowData() }

    internal class Program
    {
        static void Main(string[] args)
        {
            TextDocument doc = new TextDocument("John", "Some content");
            doc.ShowData();

            Console.ReadKey();
        }      
    }
}
