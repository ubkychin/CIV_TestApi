namespace TestApi.Models
{
    public class Car
    {
        public string Rego { get; set; }
        public string Colour { get; set; }
        
        
        public Car() { }

        public Car(string rego, string colour) {
            Rego = rego;
            Colour = colour;
        }



        
    }
}