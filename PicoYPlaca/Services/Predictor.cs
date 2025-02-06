using PicoYPlaca.Models;
using System;
using PicoYPlaca.Rules;

namespace PicoYPlaca.Services
{
    public class Predictor
    {
        private readonly Vehicle _vehicle;
        private readonly DateTime _date;
        private readonly TimeSpan _time;

        public Predictor(Vehicle vehicle, string date, string time)
        {
            _vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            _date = DateTime.Parse(date);
            _time = TimeSpan.Parse(time);
        }

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public TimeSpan Time
        {
            get { return _time; }
        }


        private bool IsRestrictedTime()
        {
            foreach (var period in Restrictions.RestrictedHours)
            {
                var start = TimeSpan.Parse(period[0]);
                var end = TimeSpan.Parse(period[1]);
                if (_time >= start && _time <= end)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CanDrive()
        {
            var dayOfWeek = _date.DayOfWeek;
            var lastDigit = _vehicle.GetLastDigit();

            if (Restrictions.RestrictionRules.ContainsKey(dayOfWeek))
            {
                foreach (var restrictedDigit in Restrictions.RestrictionRules[dayOfWeek])
                {
                    if (restrictedDigit == lastDigit && IsRestrictedTime())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public string GetResult()
        {
            return CanDrive() ? "Can drive" : "Cannot drive";
        }
    }
}

