using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiSampleApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        public List<dynamic> Get()
        
        {
            var obj = new { CustomerName = "VishalSharma", Email = "VishalSharma283@gmail.com", Address = "Pathankot"};
            List<dynamic> lst = new List<dynamic>();
            lst.Add(obj);
            lst.Add(obj);
            lst.Add(obj);
            lst.Add(obj);
            lst.Add(obj);
            lst.Add(obj); 
            lst.Add(obj);

            return lst;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
