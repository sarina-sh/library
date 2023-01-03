namespace LibraryManagement
{

    public enum ReservationStatus
    {
      Completed , 
      Canceled
    }

    public class Reservation 
    {
        public DateTime startDate ; 
        public int duration ;
        public DateTime returnDate ;
        public ReservationStatus status ;
    
        public Reservation(DateTime startDate, int duration)
        {
            this.startDate = startDate ;
            this.duration = duration ;
        }
        public static ReservationStatus getStatus()
        {  
            return status ;
        }
        public static bool reserveBook(int bookID , int id)
        {
          return true ;
        }
        public static DateTime getReturnDate()
        {
          return returnDate ;
        }
    }


}
