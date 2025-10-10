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
    }

    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }

        public abstract User ShallowCopy();

        public abstract User DeepCopy();

        public override string ToString()
        {
            return $"Id: {Id}, First name: {FirstName} Lastname: {LastName} City: {Address.City}"; 
        }
    }

    public class Freelancer : User
    {
        public string Skill { get; set; }

        public override User ShallowCopy()
        {
            return (User)this.MemberwiseClone();
        }

        public override User DeepCopy()
        {
            Freelancer clone = (Freelancer)this.MemberwiseClone();
            clone.Address = new Address(this.Address.City);
            return clone;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Tyumen");
            Freelancer original = new Freelancer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = address
            };

            Freelancer copy = (Freelancer)original.DeepCopy();
            copy.Id = 2;
            copy.Address.City = "Moscow";

            Console.WriteLine(original);
            Console.WriteLine(copy);

            Console.ReadKey();
        }
    }
}
