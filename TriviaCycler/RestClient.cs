using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace TriviaCycler
{
    class RestClient
    {
        private HttpClient client = new HttpClient();
        private const string baseURL = "https://api.api-ninjas.com/v1/trivia?category=";

        public RestClient(string category, string api_key)
        {
            UpdateCategory(category);
            client.DefaultRequestHeaders.Add("X-Api-Key", api_key);
        }

        public void UpdateCategory(string category)
        {
            client.BaseAddress = new Uri(baseURL + category);
        }

        public async Task<Question[]> GetNextQuestion()
        {
            using (HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, ""))
            {
                HttpResponseMessage httpResponse = await client.SendAsync(httpRequest);
                return JsonConvert.DeserializeObject<Question[]>(await httpResponse.Content.ReadAsStringAsync());
            }
        }
    }
}
