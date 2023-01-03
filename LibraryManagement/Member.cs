using System.Collections.Generic;

namespace LibraryManagement
{
  public class  Member :Account
  {
    public List<Book> reservedBooks ;
    public int limit ;

    public Member(int limit)
    {
      this.limit = limit ;
    }
    public static List<Book> getReservedBooks()
    {
      return reservedBooks ;
    }

  }
}

