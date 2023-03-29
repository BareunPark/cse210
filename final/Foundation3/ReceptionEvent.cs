namespace EventPlanning
{
    public class ReceptionEvent : Event
    {
        private string _rsvpEmail;
        public ReceptionEvent(string title, string description, DateTime date, Address address, string rsvpEmail) : base(title, description, date, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
        }
    }
}