using System;

namespace DarkerSmile.UnityManagement
{
    public class Time : IComparable<Time>
    {
        public Time(int hour, int minute, Meridie meridie)
        {
            Hours = hour;
            Minutes = minute;
            Meridie = meridie;
            HoursTwentyFour = Hours < 12 ? Hours : Hours + 12;
        }

        public int Hours { get; }
        public int HoursTwentyFour { get; }
        public int Minutes { get; }
        public Meridie Meridie { get; }

        public string AsTwelveHour => ToString();

        public string AsTwentyFourHour =>
            $"{(Hours + 12).ToString().PadLeft(2, '0')}:{Minutes.ToString().PadLeft(2, '0')}";


        public static Time None { get; } = new Time(0, 0, Meridie.AM);

        public static Time Now => FromTimeSpan(DateTime.UtcNow.TimeOfDay);


        public static Time TwelveHour(int hour, int minute, Meridie meridie) => new Time(hour, minute, meridie);

        public static Time At(string time) => time.Contains(" ")
            ? FromTwelveHourString(time)
            : FromTwentyFourHourString(time);

        public static Time TwentyFourHour(int hour, int minute)
        {
            if (hour > 12)
                return new Time(hour - 12, minute, Meridie.PM);
            return new Time(hour, minute, Meridie.AM);
        }


        public TimeSpan ToTimeSpan()
        {
            var hours = Meridie == Meridie.PM ? Hours + 12 : Hours;
            return new TimeSpan(hours, Minutes, 0);
        }

        public static Time FromTimeSpan(TimeSpan span) => TwentyFourHour(span.Hours, span.Minutes);

        public static TimeSpan Difference(Time timeA, Time timeB) => timeA.ToTimeSpan() - timeB.ToTimeSpan();

        public bool IsEarlierThan(Time other) => CompareTo(other) == -1;


        public static Time FromTwelveHourString(string timestring, char secondsdelimiter = ':')
        {
            var splitmeridie = timestring.Split(' ');
            var timeportion = splitmeridie[0];
            var meridie = splitmeridie[1];

            Meridie mer;
            Enum.TryParse(meridie, out mer);

            var splithourmin = timeportion.Split(secondsdelimiter);
            var hours = splithourmin[0];
            var min = splithourmin[1];

            return new Time(int.Parse(hours), int.Parse(min), mer);
        }

        public static Time FromTwentyFourHourString(string timestring, char secondsdelimiter = ':')
        {
            var splithourmin = timestring.Split(secondsdelimiter);
            var hours = splithourmin[0];
            var min = splithourmin[1];

            return TwentyFourHour(int.Parse(hours), int.Parse(min));
        }

        public override string ToString() =>
            $"{Hours.ToString().PadLeft(2, '0')}:{Minutes.ToString().PadLeft(2, '0')} {Meridie}";

        public int CompareTo(Time other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;

            if (Meridie == Meridie.PM && other.Meridie == Meridie.AM)
                return 1;
            if (Meridie == Meridie.AM && other.Meridie == Meridie.PM)
                return -1;

            if (Hours < other.Hours)
                return -1;

            if (other.Hours < Hours)
                return 1;

            if (Minutes < other.Minutes)
                return -1;

            if (Minutes > other.Minutes)
                return 1;

            return 0;
        }
    }
}