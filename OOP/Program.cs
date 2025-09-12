using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace OOP {

    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name не может быть пустым");
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;

            set
            {
                if (value < 0 || value > 85)
                {
                    throw new ArgumentOutOfRangeException(nameof(Age),"Возраст должен быть от 0 до 85");
                }
                age = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonValid = @"{ ""Name"": ""John"", ""Age"": 30 }";
            string jsonInvalid = @"{ ""Name"": ""Tom"", ""Age"": -10 }";

            try
            {
                Person person = JsonSerializer.Deserialize<Person>(jsonValid);
                Console.WriteLine($"Success: {person.Name}, {person.Age} лет");
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                
            }         
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                Person person = JsonSerializer.Deserialize<Person>(jsonInvalid);
                Console.WriteLine($"Success: {person.Name}, {person.Age} лет");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }      
    }
}
