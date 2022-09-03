using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum();
            return sum % 2 != 0;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var up = password.Any(char.IsUpper);
            var low = password.Any(char.IsLower);
            var num = password.Any(char.IsDigit);
                
                if (up == true && low == true && num == true)
                {
                    return true;
                }
                    return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
           return nums.Last() - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odd1 = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    odd1.Add(i);
                }
            }
                return odd1.ToArray();
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
