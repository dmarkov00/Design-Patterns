using LotteryParticipant_Observer_;
using System.Collections.Generic;

namespace Lottery_Object_
{
    public interface ILottery
    {
        void Register(IParticipant participant);
        void Unregister(IParticipant participant);
        void NotifyObserver(List<int> numbers);
    }
}