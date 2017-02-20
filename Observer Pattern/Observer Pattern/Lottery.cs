using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    public  class Lottery : ILottery
    {
        // Stores all the observers
        private List<IParticipant> listOfParticipants;
        private List<int> Numbers { get; set; }
        public Lottery()
        {
            listOfParticipants = new List<IParticipant>();
        }
        /// <summary>
        /// Calls update method on every participant in the list of participants
        /// </summary>
        /// <param name="numbers"></param>
        public void NotifyObserver(List<int> numbers)
        {
            foreach (IParticipant participant in listOfParticipants)
            {
                participant.Update(numbers);
            }
        }

        /// <summary>
        /// Adds participant in the list of participants
        /// </summary>
        /// <param name="participant"></param>
        public void Register(IParticipant participant)
        {
            listOfParticipants.Add(participant);
        }

        /// <summary>
        /// Removes participants
        /// </summary>
        /// <param name="participant"></param>
        public void Unregister(IParticipant participant)
        {
            listOfParticipants.Remove(participant);
        }
        /// <summary>
        /// Generates random numbers for the lottery
        /// </summary>
        /// <returns></returns>
        public List<int> GenerateRandomNumbers()
        {
            var rand = new Random();
            Numbers = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                Numbers.Add(rand.Next(20));
            }                
            // We notify all the observers after new numbers are generated
            NotifyObserver(Numbers);
            return Numbers;
        }
    }
}
