using System.Collections.Generic;

namespace LotteryParticipant_Observer_
{
    public interface IParticipant
    {
        string Name { get; set; }
        void Update(List<int> numbers);
    }
}
