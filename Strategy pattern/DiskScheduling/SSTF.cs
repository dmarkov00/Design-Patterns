using System;
using System.Collections.Generic;

namespace DiskScheduling
{
    public class SSTF : IScheduler
    {
        public int HeadLocation { get; set; }

        /// <summary>
        /// The algorith find the smallest absolute value of the substraction HeadLocation
        /// and number from the list 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetNumberToBeRemoved(List<int> numbers)
        {
            // big number used for finding minimal value
            int shortestSeekTimeNumber = int.MaxValue;
            int newValie = 0;
            int numberToRemove = 0;
            foreach (int num in numbers)
            {
                newValie = Math.Abs(HeadLocation - num);

                if (shortestSeekTimeNumber > newValie)
                {
                    shortestSeekTimeNumber = newValie;
                    numberToRemove = num;
                }

            }
            return numberToRemove;

        }

    }
}
