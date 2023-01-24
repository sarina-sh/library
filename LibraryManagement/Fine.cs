namespace LibraryManagement
{
    class Fine
    {
      public DateTime date  ;
      public  double fine   ;
      public Fine(DateTime date)
      {
        this.date = date ;
      }
      public double getFine(int bookID , int id)
      {
         DateTime d = DateTime.Now ;
         List<Book> allBooks = new List<Book>();
         List<Member> members = new List<Member>();

         Library lib = new Library(allBooks, members);
               
    
    
         for (int i = 0; i <  lib.members.Count; i++)
            {   var m = lib.members[i] ;
                if (m.id == id)
                {
                  for (int j = 0; j < m.reserved.Count ; j++)
                  {

                      Reservation b = m.reserved[j];
                    
                      if(bookID == b.book.bookID )
                      {
                        //addssf
                        if (b.dueDate < d)
                        {
                          double ne = (d.Month - b.dueDate.Month)*30 + (d.Day - b.dueDate.Day ) *  fine ;
                          fine = ne;
                          // this.fine = (d.Subtract(b.dueDate)).Tostring().Split[0].parse()  *this.fine ;

                        }
                        
                        Console.WriteLine($"The fine is {fine}") ;
                      }

                  }
                  
                }
            }
        
        return fine ;
      }
      
    }
}
