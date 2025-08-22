using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee
    {
        public string name;
        public string surname;
        public int age;
        private float salary;

        public Employee(string name, string surname, int age, float salary)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
        }

        public float getSalary()
        {
            return salary;
        }

        public float setSalary(float amount)
        {
            return salary += amount;
        }

        public virtual string Work()
        {
            return "Working";
        }
    }

    class Programmer : Employee
    {
        public string pos;

        public Programmer(
            string name, 
            string surname, 
            int age, 
            float salary, 
            string pos) : base(name, surname, age, salary)
        {
            this.pos = pos;
        }

        public override string Work()
        {
            return "typing code";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer("Bob", "Doe", 25, 30000, "Trainee");

            Console.WriteLine($"Programmer {programmer.name} {programmer.Work()}");
        
            Console.ReadKey();
        }
    }
}
