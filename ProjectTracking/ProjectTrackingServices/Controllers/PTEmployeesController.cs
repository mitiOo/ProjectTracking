using System.Collections.Generic;
using System.Web.Http;

namespace ProjectTrackingServices.Controllers
{
    public class PTEmployeesController : ApiController
    {
        // GET: api/PTEmployeesController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PTEmployeesController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PTEmployeesController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PTEmployeesController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PTEmployeesController/5
        public void Delete(int id)
        {
        }
    }
}
