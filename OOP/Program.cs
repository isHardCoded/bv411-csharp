using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Duck : IFlyable, ISwimmable 
    {
        public void Fly()
        {
            Console.WriteLine("Утка летает");
        }

        public void Swim()
        {
            Console.WriteLine("Утка плавает");
        }
    }

    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("Рыба плавает");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            Fish fish = new Fish();

            duck.Swim();
            fish.Swim();

            Console.ReadKey();
        }      
    }
}
