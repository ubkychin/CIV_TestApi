using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {

        static public List<Person> People = new List<Person>();

        public ExampleController() {
            People.Add(new Person("Jason", "007", 700));
            People.Add(new Person("James", "008", 77));
            People.Add(new Person("Maxwell", "86", 60));
            People.Add(new Person("Agent", "99", 50));
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }

        [HttpGet("{message}/{name}")]
        public string Get(string message, string name)
        {
            return message + " " + name;
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return name;
        }

        [HttpPost]
        public string Post([FromBody] Person p) {
            Person found = null;
            
            foreach (var pp in People) {
                if (p.Id == pp.Id) {
                    found = pp;
                    break;
                }
            }

            if(found != null) {
                return found.Name + " " + found.Id;
            } else {
                return "Not found";
            }
        }
    }
}