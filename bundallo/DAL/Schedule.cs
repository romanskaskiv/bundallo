namespace bundallo
{
    public class Schedule
    {
        public int ScheduleId;
        public string BarberNickname;
        public int Day;
        public int OpenHour;
        public int CloseHour;

        public Schedule()
        {
        }

        public Schedule(int scheduleId, string barberNickname, int day, int openHour, int closeHour)
        {
            ScheduleId = scheduleId;
            BarberNickname = barberNickname;
            Day = day;
            OpenHour = openHour;
            CloseHour = closeHour;
        }
    }
}
