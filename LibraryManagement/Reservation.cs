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
        public  ReservationStatus getStatus()
        {  
          ReservationStatus s = new ReservationStatus() ;
          return s ;
        }
        public  bool reserveBook(int bookID , int id)
        {
          return true ;
        }
        public  DateTime getReturnDate()
        {
           DateTime returnDate = new DateTime () ;
          return returnDate ;
        }
    }


}
