using system ;
using System.Collections.Generic;


namespace LibraryManagement
{

  public class  Librarian :Account
  {
    private List<Member> members = new List<member>();
    public static bool registerMember(Member new_member){
      return true ; 
    }
    public static bool removeMember(int id ){
      return true ;
    }
    public static List<Member> getAllMembers(){
      return  members ;
    }
  
  }
}

