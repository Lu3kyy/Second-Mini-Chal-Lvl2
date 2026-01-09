using System.Linq;

namespace myapi.Services
{
    public class CompareService : ICompareService
    {
        public string OddOrEven(int number)
        {
            var kind = number % 2 == 0 ? "even" : "odd";
            return $"The number {number} is {kind}.";
        }

        public string ReverseNumbers(string numbers)
        {
            if (numbers == null) return "You entered nothing.";
            if (!numbers.All(char.IsDigit)) return "Input must contain digits only.";
            var reversed = new string(numbers.Reverse().ToArray());
            return $"You entered {numbers}, reversed is {reversed}";
        }
    }
} 
