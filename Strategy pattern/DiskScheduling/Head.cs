using System.Collections.Generic;

namespace DiskScheduling
{
    public class Head
    {

        public Head(IScheduler scheduler)
        {
            Scheduler = scheduler;
        }
        public int NumberToBeRemoved { get; private set; }
        private IScheduler Scheduler { get; set; }

        public List<int> ScheduleNextRequstedNumber(List<int> numbers)
        {
            NumberToBeRemoved = Scheduler.GetNumberToBeRemoved(numbers);
            numbers.Remove(NumberToBeRemoved);
            return numbers;
        }
    }
}
