using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    public interface IAnimal
    {
        void MakeSound();
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    public class AnimalSoundPlayer
    {
        public void PlaySound(IAnimal animal)
        {
            animal.MakeSound();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[] {
                new Cat(),
                new Dog()
            };
                    
            AnimalSoundPlayer player = new AnimalSoundPlayer();

            foreach (var animal in animals)
            {
                player.PlaySound(animal);
            }

            Console.ReadKey();
        }      
    }
}
