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
  string role ,
  string accountStatus ,
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
    
    public List<Book> searchByMember(int id)
    {
      List<Book> borrowBooks = new List<Book>();
      return borrowBooks;
    }

    public List<Member> searchByBookName(string name)
    {
      List<Member> Bmembers = new List<Member>();
      return Bmembers;
    }

  }
}

