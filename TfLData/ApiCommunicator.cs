using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TfLData
{
    public class ApiCommunicator
    {
        private string apiUrl;
        private HttpClient client = new HttpClient();
        private readonly string appId = "b227fdc1";
        private readonly string appKey = "057462015265df205ee70678246ea99d";

        public ApiCommunicator(string apiUrl)
        {
            this.apiUrl = apiUrl;
        }

        public async Task<string> Get()
        {
            var builder = new UriBuilder(apiUrl)
            {
                Query = $"app_id={appId}&app_key={appKey}"
            };
            var response = await client.GetAsync(builder.Uri);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
