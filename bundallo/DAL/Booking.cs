namespace bundallo
{
    public class Booking
    {
        public int BookingId;
        public string UserNickname;
        public int ScheduleId;
        public int BookingHour;

        public Booking()
        {
            
        }

        public Booking(int bookingId, string userNickname, int scheduleId, int bookingHour)
        {
            BookingId = bookingId;
            UserNickname = userNickname;
            ScheduleId = scheduleId;
            BookingHour = bookingHour;
        }
    }
}