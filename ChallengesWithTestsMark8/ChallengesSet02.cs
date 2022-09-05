using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool isLetter = true;

            //if (isLetter)
            //{
            //    return char.IsLetter(c);
            //}
            //else
            //{
            //    return char.IsDigit(c);
            //}
                return (isLetter)? char.IsLetter(c): char.IsLetter(c);
          
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            //if (vals.Length % 2 == 0)
            //{
            //    return true
            //}
            //else
            //{
            //    return false;
            //}
            return (vals.Length % 2 == 0) ?true :false;
            
        }

        public bool IsNumberEven(int number)
        {
            //if(number % 2 == 0)      
            //{
            //    return true; 
            //}
            //else
            //{
            //    return false;
            //}
            return(number % 2 == 0)?true :false;
        }

        public bool IsNumberOdd(int num)
        {
            //if(num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return(num % 2 != 0)?true :false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
            return numbers.Min() + numbers.Max();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //if (str1.Length > str2.Length)
            //{
            //    return str2.Length;
            //}
            //else
            //{
            //    return str1.Length;
            //}
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var evenSum = 0;

            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

       

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //if (number <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}
            return(number <= 0)? 0: number / 2;
        }
    }
}
