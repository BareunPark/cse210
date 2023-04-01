namespace ExerciseTracker
{
    class Activity
    {
        private DateTime _date;
        protected int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummary()
        {
            string summary = _date.ToString("dd mm yyyy") + " "+ this.GetType().Name + " (" + _minutes + " min) - ";
            summary += "Distance: " + GetDistance().ToString("0.##") + " km, ";
            summary += "Speed: " + GetSpeed().ToString("0.##") + " kph, ";
            summary += "Pace: " + GetPace().ToString("0.#") + " min/km";
            return summary;
        }


    }
}