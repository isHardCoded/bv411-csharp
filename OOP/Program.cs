using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    public interface IProduct
    {
        string GetDetails();
    }

    public class Electronics : IProduct
    {
        public string GetDetails()
        {
            return "Электронное устройство: смартфон";
        }
    }

    public class Cloting : IProduct
    {
        public string GetDetails()
        {
            return "Одежда: футболка";
        }
    }

    public class Book : IProduct
    {
        public string GetDetails()
        {
            return "Книга: программирование на C#";
        }
    }

    public interface IProductFactory
    {
        IProduct CreateProduct();
    }

    public class ElectronicsFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Electronics();
        }
    }

    public class ClothingFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Cloting();
        }
    }

    public class BookFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Book();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IProductFactory factory;
            IProduct product;

            factory = new ElectronicsFactory();
            product = factory.CreateProduct();
            Console.WriteLine(product.GetDetails());

            factory = new ClothingFactory();
            product = factory.CreateProduct();
            Console.WriteLine(product.GetDetails());

            factory = new BookFactory();
            product = factory.CreateProduct();
            Console.WriteLine(product.GetDetails());

            Console.ReadKey();
        }
    }
}
