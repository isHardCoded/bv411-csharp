using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace OOP {
    internal class Program
    {
        static void Main(string[] args)
        {

            var set = new HashSet<int>() { 1, 2, 3, 4, 5 };

            set.UnionWith(new int[] {5, 6, 7, 8});

            //set.ExceptWith(new int[] { 5, 6, 7, 8 });

            //set.IntersectWith(new int[] { 1, 10, 2, 20, 3, 30 });

            set.RemoveWhere(x => x % 2 == 0);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
