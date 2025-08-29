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

    class Rectangle : Figure
    {
        // создать свойства ширины и высоты
        private double width;
        private double height;

        // создать методы для работы со свойствами
        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                throw new ArgumentException("Ширина должна быть больше нуля");
            }

            this.width = width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            if (height < 0)
            {
                throw new ArgumentException("Высота должна быть больше нуля");
            }

            this.height = height;
        }

        public Rectangle(double width, double height)
        {
            SetName("Прямоугольник");
            SetWidth(width);
            SetHeight(height);
        }

        // реализовать методы Area() и ShowData()
        public override double Area()
        {
            return width * height;
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
            Circle circle = new Circle(5);
            circle.ShowData();

            Rectangle rectangle = new Rectangle(2, 5);
            rectangle.ShowData();

            Console.ReadKey();
        }
    }
}
