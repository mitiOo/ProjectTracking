using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTrackingServices.Models;

namespace ProjectTrackingServices.Controllers
{
    [EnableCors(origins: "http://localhost:1630", headers: "*", methods: "*")]
    public class PTEmployeesController : ApiController
    {
      
        // GET: api/PTEmployeesController
        [Route("api/ptemployees")]
        public HttpResponseMessage Get()
        {
            var employees = EmployeesRepository.GetAllEmployees();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees/{name:alpha}")]
        public HttpResponseMessage SearchByName(string name)
        {
            var employees= EmployeesRepository.SearchEmployeesByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        // GET: api/PTEmployeesController/5
        [Route("api/ptemployees/{id?}")]
        public HttpResponseMessage GetEmployee(int? id)
        {
            var emp = EmployeesRepository.GetEmployee(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, emp);
            return response;
        }

        // POST: api/PTEmployeesController
        [Route("api/employees")]
        public HttpResponseMessage Post([FromBody]Employee e)
        {
            var emp = EmployeesRepository.InsertEmployee(e);
            var response = Request.CreateResponse(HttpStatusCode.OK, emp);  
            return response;
        }

        // PUT: api/PTEmployeesController/5
        [Route("api/employees")]
        public HttpResponseMessage Put(Employee e)
        {
            var emp = EmployeesRepository.UpdateEmployee(e);
            var response = Request.CreateResponse(HttpStatusCode.OK, emp);
            return response;
        }

        // DELETE: api/PTEmployeesController/5
        [Route("api/employees")]
        public HttpResponseMessage Delete(int id)
        {
            var emp = EmployeesRepository.DeleteEmployee(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, emp);
            return response;
        }
    }
}
