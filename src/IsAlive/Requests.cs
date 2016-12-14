using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IsAlive
{
    public class Requests
    {
        public async Task HacerRequest(string url)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, new Uri("http://mopc.gob.do/"));
            HttpResponseMessage response = await client.SendAsync(request);
        }
    }
}
