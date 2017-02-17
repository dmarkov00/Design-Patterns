using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    public  class Lottery : ILottery
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

            for (int i = 0; i < 10; i++)
            {
                Numbers.Add(rand.Next(20));
            }
            // We notify all the observers after new numbers are generated
            NotifyObserver(Numbers);
            return Numbers;

        }
    }
}
