using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{

    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;

            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var num = numbers.OrderBy(x => x).ToArray();
            return numbers.SequenceEqual(num);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";
            foreach(var w in words)
            {
                if (w.Trim().Length > 0)
                {
                    sentence += w.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }
            return sentence.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> list = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return list.ToArray();
            }
            for (int i = 3; i < elements.Count; i+= 4)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

