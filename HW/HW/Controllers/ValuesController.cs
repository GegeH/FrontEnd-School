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
        private static List<Person> _allPerson = new List<Person>();
        private static  string filename = @"D:\FrontEnd-School\HW\HW\data.json";
        public ValuesController()
        {            
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
        [HttpGet]
        [EnableCors("http://localhost:5778", "*", "GET")]
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
       
        [Route("api/Create")]
        [HttpPost]
        [EnableCors("*", "*", "GET,POST")]
        public void Create([FromBody]Person input)
        {
            _allPerson.Add(input);
            string jsonInput = JsonConvert.SerializeObject(_allPerson);
            System.IO.File.WriteAllText(filename, jsonInput);


        }

        // PUT api/values/5
    
        [EnableCors("*", "*", "PUT")]
        public void Put(int id, [FromBody]Person value)
        {
            var person = _allPerson.Single(m => m.Id == id);
            person.CorrectNumber = value.CorrectNumber;
            person.Progress = value.Progress;
            string jsonInput = JsonConvert.SerializeObject(_allPerson);
            System.IO.File.WriteAllText(filename, jsonInput);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
