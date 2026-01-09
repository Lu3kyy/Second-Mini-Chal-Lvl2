using System.Linq;

namespace myapi.Services
{
    public class PersonService : IPersonService
    {
        public string ReverseAlphanumeric(string input)
        {
            if (input == null) return "You entered nothing.";
            var reversed = new string(input.Reverse().ToArray());
            return $"You entered {input}, reversed is {reversed}";
        }
    }
}
