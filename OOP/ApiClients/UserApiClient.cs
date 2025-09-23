using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ApiClients
{
    internal class UserApiClient : ApiClient
    {
        public UserApiClient(HttpClient client) : base(client) {  }

        public Task<string> GetUsersAsync()
        {
            return GetAsync("/users");
        }
    }
}
