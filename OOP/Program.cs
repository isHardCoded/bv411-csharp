using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using OOP.ApiClients;

namespace OOP {
   


    internal class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();

            var userApiClient = new UserApiClient(httpClient);
            var commentApiClient = new CommentApiClient(httpClient);

            var users = await userApiClient.GetUsersAsync();
            var comments = await commentApiClient.GetCommentsAsync();

            Console.WriteLine(users);
            Console.WriteLine(comments);

            Console.ReadKey();
        }
    }
}
