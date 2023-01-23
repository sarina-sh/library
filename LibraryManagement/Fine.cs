namespace LibraryManagement
{
    class Fine
    {
      public DateTime date  ;
      public  double fine =0  ;
      public Fine(DateTime date)
      {
        this.date = date ;
      }
      public double getFine(int bookID , int id)
      {
        DateTime d - DateTime.Now ;
        
        for (int i = 0; i < Library.members.Count; i++)
            {   m = Library.members[i] ;
                if (m.id == id)
                {
                  for (int j = 0; j < m.reserved.Count ; j++)
                  {
                      b = m.reserved[j]
                      if(bookID == b.book.bookID )
                      {
                        //addssf
                        if (b.book.dueDate < d)
                        {
                          this.fine = (d - b.book.dueDate)*this.fine 

                        }
                        
                        Console.WriteLine($"The fine is {this.fine}") ;
                      }

                  }
                  
                }
            }
        
        return this.fine ;
      }
      
    }
}