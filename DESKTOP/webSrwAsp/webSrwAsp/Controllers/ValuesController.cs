using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webSrwAsp.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values
        public void Get(int a, int b, string operation)
        {
            double res = 0;
            switch (operation)
            {
                case "*":
                    res = a * b;
                    break;
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "/":
                    res = a / b;
                    break;
            }
            Request.CreateResponse(HttpStatusCode.OK, res.ToString());
        }
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
