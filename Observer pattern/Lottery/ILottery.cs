using LotteryParticipant_Observer_;

namespace Lottery
{

    public interface ILottery
    {
        void Register(IParticipant participant);
        void Unregister(IParticipant participant);
        void NotifyObserver();
    }
}
