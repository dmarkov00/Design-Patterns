using System;
using System.Collections.Generic;

namespace DiskScheduling
{
    public class Elevator : IScheduler
    {
        public int HeadLocation { get; set; }
        /// <summary>
        /// Makes a list with the numbers smaller than the head location
        /// proceses them first, if there aren't any processes the rest 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetNumberToBeRemoved(List<int> numbers)
        {
            // used not to reference to the orginal list
            List<int> listToBeSorted = new List<int>();
            listToBeSorted.AddRange(numbers);
            listToBeSorted.Sort();

            List<int> smallerThanHeadLocationNumbers = new List<int>();
            foreach (int num in listToBeSorted)
            {
                if (num <= HeadLocation)
                {
                    smallerThanHeadLocationNumbers.Add(num);
                }
            }
            if (smallerThanHeadLocationNumbers.Count == 0)
            {
                if (listToBeSorted.Count == 0)
                {
                    return 0;
                }
                return listToBeSorted[0];
            }
            return smallerThanHeadLocationNumbers[smallerThanHeadLocationNumbers.Count - 1];
        }
    }
}
