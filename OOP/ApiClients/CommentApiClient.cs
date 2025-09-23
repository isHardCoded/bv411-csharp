using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ApiClients
{
    internal class CommentApiClient : ApiClient
    {
        public CommentApiClient(HttpClient httpClient) : base(httpClient) { }

        public Task<string> GetCommentsAsync()
        {
            return GetAsync("/comments");
        }
    }
}
