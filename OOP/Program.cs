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

    class UserApiClient
    {
        private HttpClient client = new HttpClient();

        public async Task<List<User>> GetUsers()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<User>>(json);
            }
            else
            {
                Console.WriteLine($"Ошибка при получении данных с ресурса {url}: {response.StatusCode}");
                return null;
            }
        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            UserApiClient userClient = new UserApiClient();

            var users = await userClient.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine(user.name);
            }

            Console.ReadKey();
        }
    }
}
