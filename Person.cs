using System.Text.Json.Serialization;

namespace TestApi
{
    public class Person
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("Weight")]
        public int Weight { get; set; }

        public Person()
        {
        }

        public Person(string name, string id, int weight)
        {
            this.Name = name;
            this.Id = id;
            this.Weight = weight;
        }
        
    }
}