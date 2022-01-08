using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace TriviaCycler
{
    class RestClient
    {
        private static HttpClient client = new HttpClient();
        private const string baseURL = "https://api.api-ninjas.com/v1/trivia?category=";

        public RestClient(string category)
        {
            UpdateCategory(category);
        }

        public void UpdateCategory(string category)
        {
            client.BaseAddress = new Uri(baseURL + category);
        }

        public async Task<string> GetNextQuestion()
        {
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, ""))
            {
                HttpResponseMessage response = await client.SendAsync(request);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
