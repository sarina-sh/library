using System.Collections.Generic;
using System;
using System.Globalization;
namespace LibraryManagement
{

  public class Librarian : Account
  {
    public Librarian( string name ,
                      string gender ,
                      int age ,
                      int id ,
                      string emailAddress ,
                      string number,string password)
                      :base( name ,
                            gender ,
                            age ,
                            id ,
                            emailAddress ,
                            number,
                            password 
                      )
    {

    }
    
    List<LibCard> lib = new List<LibCard> () ;


    public bool printLibCard(Member member){ 
      DateTime now = DateTime.Now;
      LibCard lib_card = new LibCard((
        lib.Count) +1, now, true);
      lib.Add(lib_card);
      Console.Write("Libcard printed.");
      return true;
    }
    
  }
}

