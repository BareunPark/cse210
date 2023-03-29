namespace EventPlanning
{
    public abstract class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private Address _address;
        public Event (string title, string description, DateTime date, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _address = address;
        }
        public string GetStandardDetails()
        {
            return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_date.ToString(@"hh\:mm")}\n{_address.ToString()}";
        }

        public abstract string GetFullDetails();
        public string GetShortDescription()
        {
            return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
        }

    }
}