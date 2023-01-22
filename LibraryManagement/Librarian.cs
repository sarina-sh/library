using System.Collections.Generic;

namespace LibraryManagement
{

  public class Librarian : Account
  {
    public Librarian( string name ,
                      string gender ,
                      int age ,
                      int id ,
                      string password ,
                      Role role ,
                      AccountStatus accountStatus ,
                      string emailAddress ,
                      string number)
                      :base( name ,
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
    
    public  bool registerMember(Member new_member){
      return true ; 
    }
    public  bool removeMember(int id ){
      return true ;
    }
    public  List<Member> getAllMembers(){
      List<Member> members = new List<Member>();
      return  members ;
    }
    
    public bool printLibCard(Member member){
      LibCard card = new LibCard(member.id, member.name, member.dueDate, true);
      Console.Write("Print Card.");
      return true;
    }
    
  }
}

