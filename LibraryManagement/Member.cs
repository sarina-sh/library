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
  Role role ,
  AccountStatus accountStatus ,
  string emailAddress ,
  string number 
) :base( name ,
   gender ,
  age ,
  id ,
  password ,
  role ,
  accountStatus ,
   emailAddress ,
  number 
)
    {

    }
    public List<Book> reservedBooks ;
    public int limit ;

    
    public static List<Book> getReservedBooks()
    {
      List<Book> books =  new List<Book> () ;
      return books ;
    }

  }
}

