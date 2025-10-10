using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public int Data;

        public ConcretePrototype(int data) 
        {
            Data = data;
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype(this.Data);
        }
    }   

    internal class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype original = new ConcretePrototype(15);
            ConcretePrototype copy = (ConcretePrototype)original.Clone();

            Console.WriteLine($"Original data: {original.Data}");
            Console.WriteLine($"Copy data: {copy.Data}");

            copy.Data = 30;
            Console.WriteLine($"После изменения Original data: {original.Data}");
            Console.WriteLine($"После изменения Copy data: {copy.Data}");

            Console.ReadKey();
        }
    }
}
