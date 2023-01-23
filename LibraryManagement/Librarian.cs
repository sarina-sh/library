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
    
    List<LibCard> lib = new List<LibCard> () ;


    public bool printLibCard(Member member){ 
      DateTime now = new DateTime.Now(); 
      LibCard lib_card = new LibCard(lib.count+1, now, true)
      lib.add(lib_card) ;
      Console.Write("Libcard printed.");
      return true;
    }
    
  }
}

