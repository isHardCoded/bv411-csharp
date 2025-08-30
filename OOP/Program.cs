using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    // abstract Document { id, author, abstract ShowData() }
    abstract class Document
    {
        private Guid id;
        private string author;

        public Guid Id
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
            Id = Guid.NewGuid();
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

    class SignedDocument : Document
    {
        private string signature;

        public string Signature
        {
            get { return signature; }
            set { signature = value; }
        }

        public SignedDocument(string author, string signature) : base(author)
        {
            Signature = signature;
        }

        public override void ShowData()
        {
            Console.WriteLine($"Текстовый документ (ID: {Id})");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Подпись: {Signature}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[]
            {
                new TextDocument("john", "some content"),
                new SignedDocument("tom", "sign_tom"),
            };

            foreach (var document in documents)
            {
                document.ShowData();
                Console.WriteLine();
            }

            Console.ReadKey();
        }      
    }
}
