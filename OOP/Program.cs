using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    public interface IProduct
    {
        void DoSomething();
    }

    public class ProductA : IProduct 
    {
        public void DoSomething() 
        {
            Console.WriteLine("Product A doing something");
        }
    }

    public class ProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Product B doing something");
        }
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void SomeOperation()
        {
            var product = FactoryMethod();
            product.DoSomething();
        }
    }

    public class ConcreteCreateA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }

    public class ConcreteCreateB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreateA();
            creator.SomeOperation();

            creator = new ConcreteCreateB();
            creator.SomeOperation();

            Console.ReadKey();
        }
    }
}
