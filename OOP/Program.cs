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
            Console.WriteLine($"Площадь: {Area():F2}");
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
            Console.WriteLine($"Радиус: {radius}");
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
            Console.WriteLine($"Ширина: {width}");
            Console.WriteLine($"Высота: {height}");
        }
    }

    class Triangle : Figure
    {
        private double @base;
        private double height;

        public double GetBase()
        {
            return @base;
        }

        public void SetBase(double @base)
        {
            this.@base = @base;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            if (height < 0)
            {
                throw new ArgumentException("Основание должно быть больше нуля");
            }
            this.height = height;
        }

        public Triangle(double @base, double height)
        {
            SetName("Треугольник");
            SetBase(@base);
            SetHeight(height);
        }

        public override double Area()
        {
            return @base * height * 0.5;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Основание: {@base}");
            Console.WriteLine($"Высота: {height}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Circle(5),
                new Rectangle(2, 5),
                new Triangle(10, 5)
            };

            foreach(var figure in figures)
            {
                figure.ShowData();
                Console.WriteLine();
            }

            Console.ReadKey();
        }      
    }
}
