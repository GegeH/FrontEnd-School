using HW.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HW.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [EnableCors("http://localhost:5794", "*", "GET")]
        public IEnumerable<Person> Get()
        {
            //string filename = @"C:\Users\Gege\Documents\Visual Studio 2015\Projects\DotNET_InClass\FrontEnd_InClass\FProj\FrontEnd-School\HW\HW\data.txt";
            string text = System.IO.File.ReadAllText(filename);
            var person = JsonConvert.DeserializeObject<List<Person>>(text);
            return person;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [EnableCors("*", "*", "GET,POST")]
        public bool Post([FromBody]Person value)
        {
            return false;
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
