using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace homework.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            
           string filename = @"D:\FrontEnd-School\homework\homework\ajax\data.txt";
           string text = System.IO.File.ReadAllText(filename);
            var person = JsonConvert.DeserializeObject<List<Person>>(text);
         
            return person;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            string filename = @"D:\FrontEnd-School\homework\homework\ajax\data.txt";
            string text = System.IO.File.ReadAllText(filename);
            var person = JsonConvert.DeserializeObject<List<Person>>(text);

            return person[id];
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]string value)
        {
            return false;
        }
      
    }
}
