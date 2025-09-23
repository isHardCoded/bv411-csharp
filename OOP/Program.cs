using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Http;

namespace OOP {
    class CommentApiClient
    {
        private HttpClient client = new HttpClient();

        public async Task<List<Comment>> GetComments()
        {
            string url = "https://jsonplaceholder.typicode.com/comments";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Comment>>(json);
            } else
            {
                Console.WriteLine($"Ошибка при получении данных с ресурса {url}: {response.StatusCode}");
                return null;
            }
        }
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

            CommentApiClient commentClient = new CommentApiClient();

            var comments = await commentClient.GetComments();

            foreach (var comment in comments)
            {
                Console.WriteLine($"Айди: {comment.id}");
                Console.WriteLine($"Заголовок: {comment.name}");
                Console.WriteLine($"Контент: {comment.body}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
