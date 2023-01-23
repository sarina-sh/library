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
    
    
    public bool printLibCard(Member member){
      LibCard card = new LibCard(member.id, member.name, member.dueDate, true);
      Console.Write("Print Card.");
      return true;
    }
    
  }
}

