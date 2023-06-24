using Patient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Patient.Controllers
{
    public class ValuesController : ApiController
    {
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


        [Route("api/values/GetLogin")]
        [HttpPost]
        public string GetLogin(Class1 login)
        {
            BAL bal = new BAL();
            string response = bal.GetLogin(login);
            return response;

        }

        [Route("api/values/GetName")]
        [HttpGet]
        public string GetName()
        {
            BAL bal = new BAL();
            string response = bal.GetName();
            return response;
        }

        [Route("api/values/GetNid")]
        [HttpGet]
        public string GetNid()
        {
            BAL bal = new BAL();
            string response = bal.GetNid();
            return response;
        }

        [Route("api/values/GetDOB")]
        [HttpGet]
        public string GetDOB()
        {
            BAL bal = new BAL();
            string response = bal.GetDOB();
            return response;
        }

        [Route("api/values/GetGender")]
        [HttpGet]
        public string GetGender()
        {
            BAL bal = new BAL();
            string response = bal.GetGender();
            return response;
        }

        [Route("api/values/GetAddress")]
        [HttpGet]
        public string GetAddress()
        {
            BAL bal = new BAL();
            string response = bal.GetAddress();
            return response;
        }

        [Route("api/values/GetPhone")]
        [HttpGet]
        public string GetPhone()
        {
            BAL bal = new BAL();
            string response = bal.GetPhone();
            return response;
        }

        [Route("api/values/GetEmail")]
        [HttpGet]
        public string GetEmail()
        {
            BAL bal = new BAL();
            string response = bal.GetEmail();
            return response;
        }

        [Route("api/values/GetAllerg")]
        [HttpGet]
        public string GetAllerg()
        {
            BAL bal = new BAL();
            string response = bal.GetAllerg();
            return response;
        }

        [Route("api/values/GetSympt")]
        [HttpGet]
        public string GetSympt()
        {
            BAL bal = new BAL();
            string response = bal.GetSympt();
            return response;
        }
    }
}
