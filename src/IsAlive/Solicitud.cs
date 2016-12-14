using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IsAlive
{
    public class Solicitud
    {

        public async Task<bool> HacerRequest()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, new Uri("https://mopc.gob.do/"));
            HttpResponseMessage response = await client.SendAsync(request);

            var a = response.Content.ToString().Length;
            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;
        }
    }
}
