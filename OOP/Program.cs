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

        public Document(string id, string author)
        {
            Id = id;
            Author = author;
        }

        public abstract void ShowData();
    }

    // TextDocument : Document { content, override ShowData() }

    // SignedDocument : Document { signature, override ShowData() }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Guid uuid = Guid.NewGuid();
            Console.WriteLine(uuid.ToString());

            Console.ReadKey();
        }      
    }
}
