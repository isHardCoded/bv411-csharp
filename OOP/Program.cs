using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {

    abstract class Figure
    {
        protected string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public virtual void ShowData()
        {
            Console.WriteLine($"Фигура: {GetName()}");
            Console.WriteLine($"Площадь: {Area()}");
        }
    }

    class Circle : Figure
    {
        private double radius;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }

            this.radius = radius;
        }

        public Circle(double radius)
        {
            SetName("Круг");
            SetRadius(radius);
        }

        public override double Area()
        {
            // Pi * r^2
            return Math.PI * radius * radius;
        }

        public override void ShowData()
        {
            base.ShowData();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
