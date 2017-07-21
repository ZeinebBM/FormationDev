using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {   // GET api/values/5
        public double Multi(double id1, double id2)
        { 
            return id1*id2 ;
        }

        public double BMI(double h, double w)
        {  if (h>0)
            {
                return w / (h * h);
            }
            else
            {
                return 0;
            }
       
           
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
