using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Http;

namespace OOP {
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/users";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                List<User> users = JsonSerializer.Deserialize<List<User>>(json);

                foreach (User user in users)
                {
                    Console.WriteLine($"Name: {user.name}\n Username: {user.username}\n Email: {user.email}");
                }
            } else
            {
                Console.WriteLine($"Ошибка при получении данных с ресурса {url}: {response.StatusCode}");
            }

            Console.ReadKey();
        }
    }
}
