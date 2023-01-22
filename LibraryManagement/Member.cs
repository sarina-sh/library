using System.Collections.Generic;

namespace LibraryManagement
{
  public class  Member :Account
  {
    public Member( string name ,
  string gender ,
  int age ,
  int id ,
  string password ,
  string emailAddress ,
  string number 
) :base( name ,
   gender ,
  age ,
  id ,
  password ,
   emailAddress ,
  number 
)
    {

    }
    public List<Book> reservedBooks  = new List<Book>();
    public int limit ;
    public LibCard card;
    

    
    public List<Book> getReservedBooks()
    {
      return reservedBooks ;
    }
    
    
  }
  
}

