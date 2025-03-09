using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number; 
                }
                else
                {
                    total -= number; 
                }
            }
            return total;
        }
        
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length };
            return lengths.Min(); 
        }
        
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            return numbers.Min(); 
        }
        
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength2 + sideLength3 > sideLength1) &&
                   (sideLength1 + sideLength3 > sideLength2);
        }
        
        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }
        
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(o => o == null);
            return nullCount > objs.Length / 2; 
        }
        
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            var evens = numbers.Where(n => n % 2 == 0);
            if (!evens.Any()) return 0; 

            return evens.Average();
        }
        
        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("number", "Number must be non-negative");

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i; 
            }
            return result;
        }
    }
}
