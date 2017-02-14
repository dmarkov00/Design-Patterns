using System;
using System.Collections.Generic;

namespace DiskScheduling
{

    public class FCFS : IScheduler
    {
        public int HeadLocation { get; set; }
        /// <summary>
        /// Returns the first element of the list 
        /// </summary>
        /// <param name="numbers">The list of numbers to be processed</param>
        /// <returns></returns>
        public int GetNumberToBeRemoved(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                return numbers[0];
            }
            // Some dummy value
            return 0;
        }
    }
}
