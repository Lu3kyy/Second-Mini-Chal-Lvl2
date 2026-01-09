namespace myapi.Services
{
    public class AddService : IAddService
    {
        public string CreateMadLib(string name, string place, string noun, string verb, string adjective)
        {
            // Simple MadLib-style sentence using the supplied values
            return $"{name} went to {place} to {verb} a {adjective} {noun}. It was an unforgettable day!";
        }
    }
} 
