using System.Collections.Generic;

namespace Observer_Pattern
{
    public interface ILottery
    {
        void Register(IParticipant participant);
        void Unregister(IParticipant participant);
        void NotifyObserver(List<int> numbers);
    }
}
