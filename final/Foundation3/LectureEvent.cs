namespace EventPlanning
{
    public class LectureEvent : Event
    {
        private string _speakerName;
        private int _capacity;
        public LectureEvent(string title, string description, DateTime date, Address address, string speakerName, int capacity) : base(title, description, date, address)
        {
            _speakerName = speakerName;
            _capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
        }
    }
}