using OOP.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ApiClients
{
    internal abstract class ApiClient
    {
        protected HttpClient _httpClient;

        protected ApiClient(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
            _httpClient.BaseAddress = new System.Uri(ApiConstants.BaseUrl);
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            } 
            else
            {
                return null;
            }
        }
    }
}
