namespace EventPlanning
{
    public class OutdoorGatheringEvent : Event
    {
        private string _weatherStatement;
        public OutdoorGatheringEvent(string title, string description, DateTime date, Address address, string weatherStatement) : base(title, description, date, address)
        {
            _weatherStatement = weatherStatement;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nWeather: {_weatherStatement}";
        }
    }
}