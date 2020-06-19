using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API1.Controllers
{
    public class ValuesController : ApiController
    {
        static HttpClient client = new HttpClient();

        // GET api/values
        public IEnumerable<string> Get()
        {
            string[] data = new string[] { "Hello World from API 1 !" };
            return data;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public async Task<IEnumerable<string>> Post(string path = "")
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "http://localhost/API2/api/Values";
            }
            IEnumerable<string> data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path, data);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<IEnumerable<string>>();
            }
            return data;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "Change id = " + id.ToString() + " with value = " + value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
