using System.Collections.Generic;

namespace DiskScheduling
{
    public interface IScheduler
    {
        int GetNumberToBeRemoved(List<int> numbers);
        int HeadLocation { get; set; }

    }
}
