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

    private List<Member> members = new List<Member>();
    public static bool registerMember(Member new_member){
      return true ; 
    }
    public static bool removeMember(int id ){
      return true ;
    }
    public static List<Member> getAllMembers(){
      List<Member> members = new List<Member>();
      return  members ;
    }
  
  }
}

