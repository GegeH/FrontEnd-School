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
         private List<Person> _allPerson = new List<Person>();

        public ValuesController()
        {
            //string filename = @"C:\Users\Gege\Documents\Visual Studio 2015\Projects\FrontEnd_InClass\FProj\FrontEnd-School\HW\HW\data.txt";
            string filename = @"D:\FrontEnd-School\HW\HW\data.txt";
            string text = System.IO.File.ReadAllText(filename);
            var person = JsonConvert.DeserializeObject<List<Person>>(text);
            _allPerson = person;
        }

        // GET api/values
        [HttpGet]
        [EnableCors("http://localhost:5778", "*", "GET")]
        public IEnumerable<Person> Get()
        {           
            return _allPerson;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return _allPerson.SingleOrDefault(m => m.Id == id);
        }

        // POST api/values

        [EnableCors("*", "*", "GET,POST")]
        public Person Post([FromBody]Person person)
        {
           // if found, return full properties of person
           // if not found, return null
            return _allPerson.SingleOrDefault(m => m.Id == person.Id && m.Password == person.Password);
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
