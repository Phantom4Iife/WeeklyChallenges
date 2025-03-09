using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }
        
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            
            int sumOfOdds = numbers.Where(n => n % 2 != 0).Sum();
            
            return sumOfOdds % 2 != 0;
        }
        
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            
            return hasUpper && hasLower && hasDigit;
        }
        
        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }
        
        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }
        
        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            
            return dividend / divisor;
        }
        
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        
        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 99).Where(n => n % 2 != 0).ToArray();
        }
        
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
