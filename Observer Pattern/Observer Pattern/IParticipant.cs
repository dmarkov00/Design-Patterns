using System.Collections.Generic;

namespace Observer_Pattern
{
    public interface IParticipant
    {
        string Name { get; set; }
        void Update(List<int> numbers);
    }
}
