namespace LibraryManagement
{

    public enum ReservationStatus
    {
      Completed , 
      Canceled, 
      Returned
    }

    public class Reservation 
    {
        public DateTime startDate ; 
        public DateTime returnDate ;
        public ReservationStatus status ;
        public Book book;
        public DateTime dueDate;
    
        public Reservation(DateTime startDate, DateTime dueDate, Book book)
        {
            this.startDate = startDate ;
            this.dueDate = dueDate;
            this.book = book;
        }
        
        public ReservationStatus getStatus()
        {  
            return status;
        }
        
        public  DateTime getStartDate()
        {
            return startDate ;
        }
        
        public  DateTime getReturnDate()
        {
            return returnDate ;
        }
    }
    

}
