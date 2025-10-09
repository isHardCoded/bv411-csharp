using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    internal class Program
    {
        public class Computer
        {
            public string CPU { get; }
            public string MotherBoard { get; }
            public int RAM { get; }
            public int Storage { get; }
            public bool HasGraphicsCard { get; }

            private Computer(Builder builder)
            {
                CPU = builder.CPU;
                RAM = builder.RAM;
                MotherBoard = builder.MotherBoard;
                Storage = builder.Storage;
                HasGraphicsCard = builder.HasGraphicsCard;
            }

            public class Builder
            {
                public string CPU { get; private set; }
                public string MotherBoard { get; private set; }
                public int RAM { get; private set; }
                public int Storage { get; private set; } = 256;
                public bool HasGraphicsCard { get; private set; } = false;

                public Builder(string cpu, string motherboard, int ram)
                {
                    CPU = cpu;
                    RAM = ram;
                    MotherBoard = motherboard;
                }

                public Builder SetStorage(int storage)
                {
                    Storage = storage;
                    return this;
                }

                public Builder SetGraphicsCard(bool hasGraphicsCard)
                {
                    HasGraphicsCard = hasGraphicsCard;
                    return this;
                }

                public Computer Build()
                {
                    return new Computer(this);
                }
            }
        }

        static void Main(string[] args)
        {
            var pc = new Computer.Builder("Artem", "ASUS12345", 128)
                .SetStorage(256)
                .SetGraphicsCard(true)
                .Build();
            

            Console.ReadKey();
        }
    }
}
