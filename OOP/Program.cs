using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace OOP {

    public class Address
    {
        public string City { get; set; }

        public Address(string city)
        {
            City = city;
        }

        public string GetCity()
        {
            return City;
        }

        public void SetCity(string city)
        {
            City = city;
        }
    }
        public class Person
    {
        public string Name { get; set; }
        public Address Address {  get; set; }

        public Person(string name, Address address) 
        {
            Name = name;
            Address = address;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Address = new Address(this.Address.City);
            return clone;
        }

        public string Show()
        {
            return $"Name: {Name}, Address: {Address.GetCity()}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Tyumen");
            Person person = new Person("John", address);

            //Console.WriteLine("Shallow Copy");
            //Person copyPerson = person.ShallowCopy();
            //Console.WriteLine($"Original: {person.Show()}");
            //Console.WriteLine($"Copy: {copyPerson.Show()}");

            //copyPerson.Address.SetCity("Moscow");
            //Console.WriteLine($"После изменения Original: {person.Show()}");
            //Console.WriteLine($"После изменения Copy: {copyPerson.Show()}");

            Console.WriteLine("Deep Copy");
            Person deepClonePerson = person.DeepCopy();
            Console.WriteLine($"Original: {person.Show()}");
            Console.WriteLine($"Copy: {deepClonePerson.Show()}");

            deepClonePerson.Address.SetCity("Moscow");
            Console.WriteLine($"После изменения Original: {person.Show()}");
            Console.WriteLine($"После изменения Copy: {deepClonePerson.Show()}");

            Console.ReadKey();
        }
    }
}
