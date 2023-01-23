using System.Collections.Generic;

namespace LibraryManagement
{

  public class Librarian : Account
  {
    public Librarian( string name ,
                      string gender ,
                      int age ,
                      int id ,
                      string emailAddress ,
                      string number)
                      :base( name ,
                            gender ,
                            age ,
                            id ,
                            emailAddress ,
                            number 
                      )
    {

    }

  }
}

