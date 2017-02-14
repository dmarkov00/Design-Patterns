using System;
using LotteryParticipant_Observer_;
using System.Collections.Generic;

namespace Lottery_Object_
{
    public class Lottery : ILottery
    {

        private List<IParticipant> listOfParticipants;
        private List<int> Numbers { get; set; }
        public Lottery()
        {
            listOfParticipants = new List<IParticipant>();
        }
        public void NotifyObserver(List<int> numbers)
        {
            foreach (IParticipant participant in listOfParticipants)
            {
                participant.Update(numbers);
            }
        }

        public void Register(IParticipant participant)
        {
            listOfParticipants.Add(participant);
        }

        public void Unregister(IParticipant participant)
        {
            listOfParticipants.Remove(participant);
        }
        public List<int> GenerateRandomNumbers()
        {
            var rand = new Random();
            Numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Numbers.Add(rand.Next(20));
            }
            NotifyObserver(Numbers);
            return Numbers;

        }
    }
}
