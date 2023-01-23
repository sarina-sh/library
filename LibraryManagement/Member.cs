using System.Collections.Generic;

namespace LibraryManagement
{
  public class  Member :Account
  {
    public Member( string name ,
  string gender ,
  int age ,
  int id ,
  string emailAddress ,
  string number 
) :base( name ,
   gender ,
  age ,
  id ,
   emailAddress ,
  number 
)
    {

    }
    public List<Reservation> reserved  = new List<Reservation>();
    public int limit ;
    public LibCard card;
    
    public List<Book> booksReserved = new List<Book>();
    
    
    public List<Book> getReservedBooks()
    {
      for (int i = 0; i < reserved.Count; i++)
      {
        this.booksReserved.Add(reserved[i].book);
      }
      return this.booksReserved ;
    }

    public void AddReservation(Reservation reservation)
    {
      reserved.Add(reservation);
    }
    
  }
  
}

