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
            public string GraphicsCard { get; }

            private Computer(Builder builder)
            {
                CPU = builder.CPU;
                RAM = builder.RAM;
                MotherBoard = builder.MotherBoard;
                Storage = builder.Storage;
                GraphicsCard = builder.GraphicsCard;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"CPU: {CPU}");
                Console.WriteLine($"GPU: {GraphicsCard}");
                Console.WriteLine($"MotherBoard: {MotherBoard}");
                Console.WriteLine($"RAM: {RAM}");
                Console.WriteLine($"Storage: {Storage}");
            }

            public class Builder
            {
                public string CPU { get; private set; }
                public string MotherBoard { get; private set; }
                public int RAM { get; private set; }
                public int Storage { get; private set; } = 256;
                public string GraphicsCard { get; private set; }

                public Builder() { }

                public Builder SetMotherboard(string board)
                {
                    MotherBoard = board;
                    return this;
                }

                public Builder SetCPU(string cpu)
                {
                    CPU = cpu;
                    return this;
                }

                public Builder SetRAM(int size)
                {
                    RAM = size;
                    return this;
                }

                public Builder SetStorage(int storage)
                {
                    Storage = storage;
                    return this;
                }

                public Builder SetGPU(string card)
                {
                    GraphicsCard = card;
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
            var pc1 = new Computer.Builder()
                .SetMotherboard("MotherBoard B550")
                .SetCPU("Ryzen 5 5600")
                .SetRAM(32)
                .SetStorage(512)
                .SetGPU("RTX 4060")
                .Build();

            pc1.ShowInfo();

            Console.ReadKey();
        }
    }
}
