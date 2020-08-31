using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {

        static public List<Person> People = new List<Person>();
        static public int StaticCountInstances = 0;
        public int CountInstances = 0;

        public ExampleController() {
            // People = new List<Person>();
            // People.Add(new Person("Jason", "007", 700));
            // People.Add(new Person("James", "008", 77));
            // People.Add(new Person("Maxwell", "86", 60));
            // People.Add(new Person("Agent", "99", 50));

            StaticCountInstances++;
            this.CountInstances++;
        
        }

        [HttpGet("GetAll")]
        public List<Person> GetAll() {
            return People;
        }

        [HttpGet("GetRequests")]
        public int GetRequestAmount() {
            return StaticCountInstances;
        }

        [HttpGet("{id}")]
        public Person GetPerson(string id) {
            Person found = null;

            foreach (Person p in People) {
                if (p.Id == id) {
                    found = p;
                    break;
                }
            }

            return found;
        }

        [HttpPost("Add")]
        public string AddPerson([FromBody] Person newPerson) {
            People.Add(newPerson);
            return "Person Added";
        }


        /// <summary>
        /// Return person in list with matching id
        /// </summary>
        /// <param name="findPerson"></param>
        /// <returns></returns>
        [HttpPost("Find")]
        public Person FindPerson([FromBody] Person findPerson) {
            Person found = null;

            foreach (Person p in People) {
                if (p.Id == findPerson.Id) {
                    found = p;
                    break;
                }
            }

            return found;
        }

    }
}