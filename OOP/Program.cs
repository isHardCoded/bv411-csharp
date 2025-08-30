using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    // создать интерфейс IVehicle с методами: StartEngine(), StopEngine()
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    // создать два класса Car и Motorcycle
    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигатель машины запущен");
        }

        public void StopEngine()
        {
            Console.WriteLine("Двигатель машины остановлен");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигатель мотоцикла запущен");
        }

        public void StopEngine()
        {
            Console.WriteLine("Двигатель мотоцикла остановлен");
        }
    }

    public class Plane : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигатель самолета запущен");
        }

        public void StopEngine()
        {
            Console.WriteLine("Двигатель самолета остановлен");
        }
    }

    // в каждом классе написать реализацию методов StartEngine() и StopEngine()

    // создать в программе класс TestDrive, который будет принимать объект типа IVehicle
    // и последовательно вызывать для него методы StartEngine() и StopEngine()

    public class TestDrive
    {
        public void StartTest(IVehicle vehicle)
        {
            vehicle.StartEngine();
            vehicle.StopEngine();
        }
    }

    // создать объекты Car и Motorcycle

    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle[] vehicles = new IVehicle[]
            {
                new Car(),
                new Motorcycle(),
                new Plane(),
            };

            TestDrive testDrive = new TestDrive();

            foreach (var vehicle in vehicles)
            {
                testDrive.StartTest(vehicle);
            }

            Console.ReadKey();
        }      
    }
}
