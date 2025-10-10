using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    internal class Program
    {
        public class Pizza
        {
            public string Dough { get; }
            public string Sauce { get; }
            public string Filling { get; }
            public string Size { get; }

            private Pizza(Builder builder)
            {
               Dough = builder.Dough;
               Sauce = builder.Sauce;
               Filling = builder.Filling;
               Size = builder.Size;
            }

            public class Builder
            {
                public string Dough { get; private set; }
                public string Sauce { get; private set; } = "Отсутствует";
                public string Filling { get; private set; } = "Отсутствует";
                public string Size { get; private set; } = "Отсутствует";

                public Builder(string dough)
                {
                    Dough = dough;
                }

                public Builder SetSauce(string sauce)
                {
                    Sauce = sauce;
                    return this;
                }

                public Builder SetFilling(string filling)
                {
                    Filling = filling;
                    return this;
                }

                public Builder SetSize(string size)
                {
                    Size = size;
                    return this;
                }

                public Pizza Build()
                {
                    return new Pizza(this);
                }
            }

            public string Show()
            {
                return $"Тесто: {Dough}\n Соус: {Sauce}\n Начинка: {Filling}\n Размер: {Size}";
            }
        }
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza.Builder("Тонкое")
                .SetSauce("Томатный")
                .SetFilling("Пепперони")
                .SetSize("Маленькая")
                .Build();

            Console.WriteLine(pizza.Show());
            
            Console.ReadKey();
        }
    }
}
