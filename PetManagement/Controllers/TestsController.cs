using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetManagement.Controllers
{
    public class TestsController : ApiController
    {
        // GET: api/Tests
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tests/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tests
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tests/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tests/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("api/Tests/Users")]
        public IHttpActionResult GetUsers()
        {
            using(PetManagementEntities db = new PetManagementEntities())
            {
                var users = db.Users.ToList();
                return Ok(users);
            }
        }
    }
}
